using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace YazLab1_Proje
{
	public partial class AnaEkran : Form
	{
		MySqlConnection mysqlconn = new MySqlConnection("server=localhost;database=users;Uid=root;Pwd=;SslMode=none");

		//tüm kitapları gösterdiğimiz yerin değişkenleri
		MySqlDataAdapter adapter = new MySqlDataAdapter();
		DataSet ds = new DataSet();
		int start;

		//Eklenen son 5 kitap
		MySqlDataAdapter adapter2 = new MySqlDataAdapter();
		DataSet ds2 = new DataSet();

		//en iyi 10 kitap için değişkenler
		MySqlDataAdapter adapter3 = new MySqlDataAdapter();
		DataSet ds3 = new DataSet();
		int start1;

		//popüler kitap için değişkenler
		MySqlDataAdapter adapter4 = new MySqlDataAdapter();
		DataSet ds4 = new DataSet();
		int start2;

		//Yeni Kitap için değişkenler
		MySqlDataAdapter adapter5 = new MySqlDataAdapter();
		DataSet ds5 = new DataSet();
		int start3;

		string username;

		public AnaEkran(string Kullanici_Adi)
		{
			InitializeComponent();
			start = 0;
			start1 = 0;
			start2 = 0;
			start3 = 0;
			KitaplariGöster();
			YeniKitaplar();
			EnIyi10KitapGoster();
			Populer10KitapGoster();
			username = Kullanici_Adi;
		}

		public void KitaplariGöster()
		{
			string query = "SELECT ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, KitapPDF_Yol, Resim FROM kitaplar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter.SelectCommand = cmd;

				//fill dataset
				adapter.Fill(ds, start, 5, "kitaplar"); //table and max row 5

				//set it to datagridview
				dataGridView1.DataSource = ds.Tables[0];

				//disable back button
				geri_btn.Enabled = false;

				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		//*******************tüm kitaplar sekmesinin sayfalama kodları******************************
		private void geri_btn_Click_1(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start = start - 5;
			if (start < 0)
			{
				start = 0;
				geri_btn.Enabled = false;
			}

			ds.Clear();
			adapter.Fill(ds, start, 5, "kitaplar");
			mysqlconn.Close();
		}

		private void ileri_btn_Click_1(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start = start + 5; //5 er tane gösteriyor
			geri_btn.Enabled = true;

			if (start > 272000) //max veri
			{
				start = 0; //reset
			}
			ds.Clear();
			adapter.Fill(ds, start, 5, "kitaplar");
			mysqlconn.Close();

		}

		//***********************************************************Yeni Kitaplar Kodu*************************************************

		public void YeniKitaplar()
		{
			string query = "SELECT ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, KitapPDF_Yol, Resim FROM kitaplar ORDER BY ID DESC LIMIT 5";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter2.SelectCommand = cmd;

				//fill dataset
				adapter2.Fill(ds2, start1, 5, "kitaplar"); //table and max row 5 eklenen son 5 kitap olduğu için 5 yazdık

				//set it to datagridview
				YeniKitapView.DataSource = ds2.Tables[0];
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		//*************************************en iyi 10 kitap kodu************************************
		public void EnIyi10KitapGoster()
		{
			mysqlconn.Open();
			string sorgu = "SELECT ISBN, AVG(BookRating) AS Ortalama FROM kitap_oylari GROUP BY ISBN ORDER BY Ortalama DESC LIMIT 10";
			MySqlCommand cmd2 = new MySqlCommand(sorgu, mysqlconn);

			using (MySqlDataAdapter adpt = new MySqlDataAdapter(sorgu, mysqlconn))
			{
				DataSet dset = new DataSet();
				adpt.Fill(dset);
				EnIyi10Kitap_View.DataSource = dset.Tables[0];
				mysqlconn.Close();
			}

		}

		private void EnIyi10Kitap_View_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell cell = (DataGridViewCell)EnIyi10Kitap_View.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.ColumnIndex == this.EnIyi10Kitap_View.Columns["ISBN"].Index)
			{
				// Do something when a "YourColumn" cell is clicked 
				//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

				//MessageBox.Show(ofd.FileName.GetType().ToString());// yolu yazıyor
				//axAcroPDF1.src = ofd.FileName; pdf görüntülüyor.

				//MessageBox.Show(EnIyi10Kitap_View.SelectedCells[0].Value.ToString());
				EnIyiKitapGoster form = new EnIyiKitapGoster(EnIyi10Kitap_View.SelectedCells[0].Value.ToString());
				form.TopMost = true;
				form.Show();

			}
		}

		//***********************************************************************************************

		//***********************Tüm kitaplar sekmesinin pdf açma kodu************************************

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell cell = (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.ColumnIndex == this.dataGridView1.Columns["KitapPDF_Yol"].Index)
			{
				// Do something when a "YourColumn" cell is clicked 
				//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

				//MessageBox.Show(ofd.FileName.GetType().ToString());// yolu yazıyor
				//axAcroPDF1.src = ofd.FileName; pdf görüntülüyor.
				if (dataGridView1.SelectedCells[0].Value.ToString() == "")
				{
					MessageBox.Show("Tıkladığınız kitabın PDF'i bulunmamaktadır. Lütfen Yöneticinizle iletişime geçin!", "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
				{
					//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString()); //kitabın yolunu gösteriyor sıkıntı yok!
					PDFFormu form3 = new PDFFormu(dataGridView1.SelectedCells[0].Value.ToString());
					form3.TopMost = true;
					form3.Show();
				}

			}
		}

		//***********************************Popüler Kitap Sekmesinin Kodları*******************************************
		public void Populer10KitapGoster()
		{
			mysqlconn.Open();
			string sorgu = "SELECT ISBN, COUNT(UserID) as KullanıcıSayısı FROM kitap_oylari GROUP BY ISBN ORDER BY KullanıcıSayısı DESC LIMIT 10";
			MySqlCommand cmd2 = new MySqlCommand(sorgu, mysqlconn);

			using (MySqlDataAdapter adpt = new MySqlDataAdapter(sorgu, mysqlconn))
			{
				DataSet dset = new DataSet();
				adpt.Fill(dset);
				PopulerKitapView.DataSource = dset.Tables[0];
				mysqlconn.Close();
			}
		}

		private void PopulerKitapView_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			DataGridViewCell cell = (DataGridViewCell)PopulerKitapView.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.ColumnIndex == this.PopulerKitapView.Columns["ISBN"].Index)
			{
				//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString()); //kitabın yolunu gösteriyor sıkıntı yok!
				PopülerKitapGoster form = new PopülerKitapGoster(PopulerKitapView.SelectedCells[0].Value.ToString());
				form.TopMost = true;
				form.Show();

			}
		}

		private void YeniKitapView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell cell = (DataGridViewCell)YeniKitapView.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.ColumnIndex == this.YeniKitapView.Columns["KitapPDF_Yol"].Index)
			{
				// Do something when a "YourColumn" cell is clicked 
				//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

				//MessageBox.Show(ofd.FileName.GetType().ToString());// yolu yazıyor
				//axAcroPDF1.src = ofd.FileName; pdf görüntülüyor.
				if (YeniKitapView.SelectedCells[0].Value.ToString() == "")
				{
					MessageBox.Show("Tıkladığınız kitabın PDF'i bulunmamaktadır. Lütfen Yöneticinizle iletişime geçin!", "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
				{
					//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString()); //kitabın yolunu gösteriyor sıkıntı yok!
					PDFFormu form = new PDFFormu(YeniKitapView.SelectedCells[0].Value.ToString());
					form.TopMost = true;
					form.Show();
				}

			}
		}

		private void Yenile_btn6_Click(object sender, EventArgs e)
		{
			ds4.Clear();

			string query = "SELECT ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, KitapPDF_Yol, Resim FROM kitaplar ORDER BY ISBN DESC LIMIT 5";

			try
			{
				mysqlconn.Open();
				//mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter5.SelectCommand = cmd;

				//fill dataset
				adapter5.Fill(ds5, start3, 5, "kitaplar"); //table and max row 5

				//set it to datagridview
				YeniKitapView.DataSource = ds5.Tables[0];

				//disable back button
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		private void begen_btn_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			string query = "INSERT INTO " + username + "(ISBN)VALUES (@ISBN);";
			MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
			cmd.Parameters.AddWithValue("@ISBN", ISBN_txtbox2.Text.ToString());

			int result = cmd.ExecuteNonQuery();

			if (result == 1)
			{
				MessageBox.Show("İşlem başarılı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mysqlconn.Close();
			}

			else
			{
				MessageBox.Show("HATA!İşlem Başarısız!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}
		}

		//*******************************************kitap tavsiyesi kodları****************************************
		private void goster_btn_Click(object sender, EventArgs e)
		{
			List<string> fileLines = new List<string>();

			using (var reader = new StreamReader(@"C:\Users\Cenk\Desktop\Proje\YazLab1-Proje\Tablolar.txt"))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					fileLines.Add(line);
				}
			}

			while (true)
			{
				Random rastgele = new Random();
				int sayi = rastgele.Next(0, fileLines.Count());

				if (username.Equals(fileLines.ElementAt(sayi)))
				{
					continue;
				}

				else
				{
					int index = fileLines.IndexOf(username); //online olan kullanıcının index ini al!

					mysqlconn.Open();
					string sorgu = "SELECT COUNT(*) FROM " + fileLines.ElementAt(index).ToString() + " t1, " + fileLines.ElementAt(sayi).ToString() + " t2 " + "WHERE t1.ISBN=t2.ISBN";
					MySqlCommand cmd2 = new MySqlCommand(sorgu, mysqlconn);
					Int64 sonuc = (Int64)cmd2.ExecuteScalar();

					if (sonuc >= 1)
					{
						//SELECT * from kitaplar WHERE ISBN IN (SELECT * FROM ferhat WHERE ISBN NOT IN(SELECT ISBN FROM cenk))
						string query2 = "SELECT ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, KitapPDF_Yol, Resim FROM kitaplar WHERE ISBN IN (SELECT * FROM " + fileLines.ElementAt(sayi).ToString() + " WHERE ISBN NOT IN(SELECT ISBN FROM " + fileLines.ElementAt(index).ToString() + " ))";

						using (MySqlDataAdapter adpt = new MySqlDataAdapter(query2, mysqlconn))
						{
							DataSet dset = new DataSet();
							adpt.Fill(dset);
							KitapTavsiyeView.DataSource = dset.Tables[0];
							mysqlconn.Close();
						}

						break;
					}

				}
			}
		}

		/* 
			 mysqlconn.Open();
			MySqlCommand Create_table = new MySqlCommand("DROP TABLE " + tablo1 + "," + tablo2, mysqlconn);
			int sonuc = Create_table.ExecuteNonQuery();

			if (sonuc == 1)
			{
				MessageBox.Show("Silme başarısız!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}

			else
			{
				File.WriteAllText(@"C:\Users\Cenk\Desktop\Proje\YazLab1-Proje\Tablolar.txt", String.Empty);
				MessageBox.Show("Silme başarılı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mysqlconn.Close();
			}

		 */

		private void KitapTavsiyeView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell cell = (DataGridViewCell)KitapTavsiyeView.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.ColumnIndex == this.KitapTavsiyeView.Columns["KitapPDF_Yol"].Index)
			{
				// Do something when a "YourColumn" cell is clicked 
				//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

				//MessageBox.Show(ofd.FileName.GetType().ToString());// yolu yazıyor
				//axAcroPDF1.src = ofd.FileName; pdf görüntülüyor.
				if (KitapTavsiyeView.SelectedCells[0].Value.ToString() == "")
				{
					MessageBox.Show("Tıkladığınız kitabın PDF'i bulunmamaktadır. Lütfen Yöneticinizle iletişime geçin!", "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
				{
					//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString()); //kitabın yolunu gösteriyor sıkıntı yok!
					PDFFormu form = new PDFFormu(KitapTavsiyeView.SelectedCells[0].Value.ToString());
					form.TopMost = true;
					form.Show();
				}

			}
		}

	}
}
