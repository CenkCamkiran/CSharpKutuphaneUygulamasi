using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace YazLab1_Proje
{
	public partial class YöneticiPaneli : Form
	{
		MySqlConnection mysqlconn = new MySqlConnection("server=localhost;database=users;Uid=root;Pwd=;SslMode=none");

		//kullanıcı tablosu için gerekli
		MySqlDataAdapter adapter1 = new MySqlDataAdapter();
		DataSet ds1 = new DataSet();
		int start1;

		//kitap tablosu için gerekli
		MySqlDataAdapter adapter2 = new MySqlDataAdapter();
		DataSet ds2 = new DataSet();
		int start2;

		//Sadece pdf ekleme için gerekli
		MySqlDataAdapter adapter3 = new MySqlDataAdapter();
		DataSet ds3 = new DataSet();
		int start3;

		public YöneticiPaneli()
		{
			InitializeComponent();
			start1 = 0;
			start2 = 0;
			start3 = 0;
			KullaniciGörüntüle();
			KitapGörüntüle();
			PDFGörüntüle();
		}

		//**************************************************kullanıcı sekmesi kodları***************************************************

		public void KullaniciGörüntüle()
		{
			string query = "SELECT * FROM kullanicilar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter1.SelectCommand = cmd;

				//fill dataset
				adapter1.Fill(ds1, start1, 5, "kullanicilar"); //table and max row 5

				//set it to datagridview
				KullaniciView.DataSource = ds1.Tables[0];

				//disable back button
				geri_btn2.Enabled = false;
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		private void geri_btn2_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start1 = start1 - 5;
			if (start1 < 0)
			{
				start1 = 0;
				geri_btn2.Enabled = false;
			}

			ds1.Clear();
			adapter1.Fill(ds1, start1, 5, "kullanicilar");
			mysqlconn.Close();
		}

		private void ileri_btn2_Click_1(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start1 = start1 + 5; //5 er tane gösteriyor
			geri_btn2.Enabled = true;

			if (start1 > 500) //max veri
			{
				start1 = 0; //reset

			}
			ds1.Clear();
			adapter1.Fill(ds1, start1, 5, "kullanicilar");
			mysqlconn.Close();
		}

		private void KullaniciYenile_btn2_Click(object sender, EventArgs e)
		{
			ds1.Clear();

			string query = "SELECT * FROM kullanicilar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter1.SelectCommand = cmd;

				//fill dataset
				adapter1.Fill(ds1, start1, 5, "kullanicilar"); //table and max row 5

				//set it to datagridview
				KullaniciView.DataSource = ds1.Tables[0];

				//disable back button
				geri_btn2.Enabled = false;
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		private void cikis_btn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void KullaniciSil_btn_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			string query = "DELETE FROM kullanicilar WHERE UserID=@ID";
			MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
			cmd.Parameters.AddWithValue("@ID", UserID_txtbox.Text.ToString());

			int result2 = cmd.ExecuteNonQuery();

			if (result2 == 1)
			{
				MessageBox.Show("Kullanıcı Veritabanından Başarıyla Silindi!!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mysqlconn.Close();
			}

			else
			{
				MessageBox.Show("HATA! Kullanıcı Silinemedi! Sistemde böyle bir kayıtlı kullanıcı yok!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}
		}

		//************************************************************************************************************************


		//**************************************************kitap sekmesi kodları***************************************************

		public void KitapGörüntüle ()
		{
			string query = "SELECT * FROM kitaplar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter2.SelectCommand = cmd;

				//fill dataset
				adapter2.Fill(ds2, start2, 5, "kitaplar"); //table and max row 5

				//set it to datagridview
				KitapView.DataSource = ds2.Tables[0];

				//disable back button
				geri_btn3.Enabled = false;
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}

		}

		private void geri_btn3_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start2 = start2 - 5;
			if (start2 < 0)
			{
				start2 = 0;
				geri_btn3.Enabled = false;
			}

			ds2.Clear();
			adapter2.Fill(ds2, start2, 5, "kitaplar");
			mysqlconn.Close();
		}

		private void ileri_btn3_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start2 = start2 + 5; //5 er tane gösteriyor
			geri_btn3.Enabled = true;

			if (start2 > 272000) //max veri
			{
				start2 = 0; //reset
			}

			ds2.Clear();
			adapter2.Fill(ds2, start2, 5, "kitaplar");
			mysqlconn.Close();
		}

		private void KitapYenile_btn_Click(object sender, EventArgs e)
		{
			ds2.Clear();

			string query = "SELECT * FROM kitaplar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter2.SelectCommand = cmd;

				//fill dataset
				adapter2.Fill(ds2, start2, 5, "kitaplar"); //table and max row 5

				//set it to datagridview
				KitapView.DataSource = ds2.Tables[0];

				//disable back button
				geri_btn3.Enabled = false;
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		private void cikis_btn3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void KitapEkle_btn_Click(object sender, EventArgs e)
		{
			MySqlCommand cmd;

			using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					mysqlconn.Open();
					string query = "INSERT INTO kitaplar (ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, ImageURL_S, ImageURL_M, ImageURL_L, KitapPDF_Yol)VALUES (@ISBN, @Title, @Author, @Year, @Publisher, @Image_S, @Image_M, @Image_L, @PDF);";
					cmd = new MySqlCommand(query, mysqlconn);
					cmd.Parameters.AddWithValue("@ISBN", ISBN_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Title", BookTitle_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Author", BookAuthor_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Year", YearOfPublication_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Publisher", Publisher_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Image_S", ImageURL_S_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Image_M", ImageURL_M_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Image_L", ImageURL_L_txtbox.Text.ToString());
				    cmd.Parameters.AddWithValue("@PDF", ofd.FileName.ToString());

					if (ISBN_txtbox.Text.ToString() != "" && BookTitle_txtbox.Text.ToString() != "" && BookAuthor_txtbox.Text.ToString() != "" && YearOfPublication_txtbox.Text.ToString() != "" && Publisher_txtbox.Text.ToString() != "" && ImageURL_S_txtbox.Text.ToString() != "" && ImageURL_M_txtbox.Text.ToString() != "" && ImageURL_L_txtbox.Text.ToString() != "")
					{
						int result2 = cmd.ExecuteNonQuery();

						if (result2 == 1)
						{
							MessageBox.Show("Kitap Veritabanına Başarıyla Kaydedildi!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
							mysqlconn.Close();
						}
						else
						{
							MessageBox.Show("Veritabanı İşleminde Hata Meydana Geldi!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
							mysqlconn.Close();
						}
					}

					else
					{
						MessageBox.Show("Kitap ekleme Başarısız! Bütün alanların doldurulması gerekli!!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
						mysqlconn.Close();
					}
					
					//MessageBox.Show(result.ToString()); //1 dönerse işlem başarılı demektir.

					//MessageBox.Show(ofd.FileName);// yolu yazıyor
				}
			}

		}

		private void KitapSil_btn_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			string query = "DELETE FROM kitaplar WHERE ISBN=@ISBN";
			MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
			cmd.Parameters.AddWithValue("@ISBN", ISBN_txt.Text.ToString());

			int result2 = cmd.ExecuteNonQuery();

			if (result2 == 1)
			{
				MessageBox.Show("Kitap Veritabanından Başarıyla Silindi!!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mysqlconn.Close();
			}

			else
			{
				MessageBox.Show("HATA! Kitap Silinemedi! Sistemde böyle bir kitap yok!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}
		}

		//************************************************************************************************************************

		//***************************************************Sadece PDF Ekleme yeri*********************************************************************

	    public void PDFGörüntüle ()
		{
			string query = "SELECT * FROM kitaplar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter3.SelectCommand = cmd;

				//fill dataset
				adapter3.Fill(ds3, start3, 5, "kitaplar"); //table and max row 5

				//set it to datagridview
				PDfView.DataSource = ds3.Tables[0];

				//disable back button
				geri_btn4.Enabled = false;
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		private void geri_btn4_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start3 = start3 - 5;
			if (start3 < 0)
			{
				start3 = 0;
				geri_btn4.Enabled = false;
			}

			ds3.Clear();
			adapter3.Fill(ds3, start3, 5, "kitaplar");
			mysqlconn.Close();
		}

		private void ileri_btn4_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start3 = start3 + 5; //5 er tane gösteriyor
			geri_btn4.Enabled = true;

			if (start3 > 272000) //max veri
			{
				start3 = 0; //reset
			}

			ds3.Clear();
			adapter3.Fill(ds3, start3, 5, "kitaplar");
			mysqlconn.Close();
		}

		private void Yenile_btn2_Click(object sender, EventArgs e)
		{
			ds3.Clear();

			string query = "SELECT * FROM kitaplar";

			try
			{
				mysqlconn.Open();
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				adapter3.SelectCommand = cmd;

				//fill dataset
				adapter3.Fill(ds3, start3, 5, "kitaplar"); //table and max row 5

				//set it to datagridview
				PDfView.DataSource = ds3.Tables[0];

				//disable back button
				geri_btn4.Enabled = false;
				mysqlconn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}
		}

		private void PDFekle_btn_Click(object sender, EventArgs e)
		{
			MySqlCommand cmd;

			using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					mysqlconn.Open();
					string query = "UPDATE kitaplar SET KitapPDF_Yol=@PDFYol WHERE ISBN=@ISBN;";
					cmd = new MySqlCommand(query, mysqlconn);
					cmd.Parameters.AddWithValue("@PDFYol", ofd.FileName.ToString());
					cmd.Parameters.AddWithValue("@ISBN", ISBN_txtbox2.Text.ToString());

					int result2 = cmd.ExecuteNonQuery();

					if (result2 == 1)
					{
						MessageBox.Show("Kitabın PDF Yolu Başarıyla Kaydedildi!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
						mysqlconn.Close();
					}
					else
					{
						MessageBox.Show("HATA! İşlem Başarısız! Sistemde böyle bir kitap yok", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
						mysqlconn.Close();
					}
				}
			}
		}

		private void cikis_btn2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//************************************************************************************************************************************

	}
}
