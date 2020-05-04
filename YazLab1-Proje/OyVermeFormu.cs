using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_Proje
{
	public partial class OyVermeFormu : Form
	{
		MySqlConnection mysqlconn = new MySqlConnection("server=localhost;database=users;Uid=root;Pwd=;SslMode=none");

		MySqlDataAdapter adapter = new MySqlDataAdapter();
		DataSet ds = new DataSet();
		int start;

		int sayac = 0;
		int ID;

		string username;

		public OyVermeFormu(int UserID, string Kullanici_Adi)
		{
			InitializeComponent();
			ID = UserID;
			KitaplarıGörüntüle();
			start = 0;
			username = Kullanici_Adi;
		}

		private void OyVer_btn_Click(object sender, EventArgs e)
		{

			if (ISBN_txtbox.Text.ToString() == "")
			{
				MessageBox.Show("Lütfen ISBN Alanını doldurunuz!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else
			{
				mysqlconn.Open();
				string query7 = "SELECT COUNT(*) FROM kitap_oylari WHERE UserID=@ID AND ISBN=@ISBN;";
				MySqlCommand cmd7 = new MySqlCommand(query7, mysqlconn);
				cmd7.Parameters.AddWithValue("@ID", ID);
				cmd7.Parameters.AddWithValue("@ISBN", ISBN_txtbox.Text.ToString());

				Int64 result7 = (Int64)cmd7.ExecuteScalar();

				if (result7 == 1)
				{
					MessageBox.Show("Hata! Aynı kitaba birden fazla oy veremezsiniz!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
					mysqlconn.Close();
				}

				else
				{
					mysqlconn.Close();

					mysqlconn.Open();
					string query = "INSERT INTO kitap_oylari(UserID, ISBN, BookRating)VALUES (@UserID, @ISBN, @Rating);";
					MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
					cmd.Parameters.AddWithValue("@UserID", ID.ToString());
					cmd.Parameters.AddWithValue("@ISBN", ISBN_txtbox.Text.ToString());
					cmd.Parameters.AddWithValue("@Rating", OyVermeSkalası.Value.ToString());

					int result = cmd.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("Oy Verme Başarılı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
						sayac++;
						OyVermeSayisi_txt.Text = sayac.ToString() + " kez oy verdin!";

						mysqlconn.Close();
					}

					else
					{
						MessageBox.Show("HATA!Oy Verme Başarısız!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
						mysqlconn.Close();
					}
				}
				
			}

		}

		private void OyCik_btn_Click(object sender, EventArgs e)
		{
			if (sayac >= 10)
			{
				mysqlconn.Open();
				string query = "UPDATE kullanicilar SET OyVermeDurumu='Verdi' WHERE UserID=@ID;";
				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				cmd.Parameters.AddWithValue("@ID", ID);

				int result = cmd.ExecuteNonQuery();
				mysqlconn.Close();

				this.Hide();
				AnaEkran form = new AnaEkran(username);
				form.ShowDialog();
				this.Close();
			}

			else
			{
				MessageBox.Show("Üyeliğin Tamamlanması için en az 10 kere Oy vermeniz gerekli!!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public void KitaplarıGörüntüle()
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
				KitaplarView.DataSource = ds.Tables[0];

				//disable back button
				geri_btn6.Enabled = false;

				mysqlconn.Close();

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				mysqlconn.Close();
			}

		}

		private void geri_btn6_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start = start - 5;
			if (start < 0)
			{
				start = 0;
				geri_btn6.Enabled = false;
			}

			ds.Clear();
			adapter.Fill(ds, start, 5, "kitaplar");
			mysqlconn.Close();
		}

		private void ileri_btn6_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			start = start + 5; //5 er tane gösteriyor
			geri_btn6.Enabled = true;

			if (start > 272000) //max veri kitap
			{
				start = 0; //reset
			}
			ds.Clear();
			adapter.Fill(ds, start, 5, "kitaplar");
			mysqlconn.Close();
		}
	}
}
