using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;

namespace YazLab1_Proje
{
	public partial class GirişKayıtEkranı : Form
	{
		MySqlConnection mysqlconn = new MySqlConnection("server=localhost;database=users;Uid=root;Pwd=;SslMode=none");
		string Kullanici_Adi;

		public void KullaniciCsvDosya(string filePath, int id)
		{
			var reader = new StreamReader(File.OpenRead(filePath));
			List<string> searchList = new List<string>();
			while (!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				searchList.Add(line);
			}

			//searchList.ForEach(Console.WriteLine);
			string kullanici_veri = searchList.ElementAt(id); //liste indisi 0 dan başladığı için id-1 yazdık. 0.eleman başlıklar oluyor

			string[] veriDizisi = kullanici_veri.Split(';'); //0.eleman ID, 1.eleman location, 2.eleman age

			/*foreach (string author in authorsList)
				Console.WriteLine(author);*/
			//Console.WriteLine("diziden tek tek elemanlara ulaşabiliyorum" + authorsList[0]);
			//Console.WriteLine(searchList.ElementAt(0));

			string query = "UPDATE kullanicilar SET location=@yer, age=@yas WHERE UserID=@ID;";
			MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
			cmd.Parameters.AddWithValue("@yer", veriDizisi[1]);
			cmd.Parameters.AddWithValue("@yas", veriDizisi[2]);
			cmd.Parameters.AddWithValue("@ID", id);

			int result = cmd.ExecuteNonQuery();
			mysqlconn.Close();
			//MessageBox.Show(result.ToString());

		}

		public void KitapCsvDosya(string filePath)
		{
			/*MySqlCommand cmd;

			var reader = new StreamReader(File.OpenRead(filePath));
			List<string> searchList = new List<string>();
			while (!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				searchList.Add(line);
			}

			progressBar1.Maximum = searchList.Count();
			progressBar1.Step = 1;
			progressBar1.Value = 0;

			Debug.WriteLine(searchList.Count());
			for (int i = 1; i < searchList.Count(); i++) //500 kayıt
			{
				progressBar1.Value = i;
				string veri = searchList.ElementAt(i);
				veri = Regex.Replace(veri, "\"", "");
				List<string> myList = veri.Split(';').ToList();
				//Debug.WriteLine(myList.ElementAt(0));

				string query = "INSERT INTO kitaplar(ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, ImageURL_S, ImageURL_M, ImageURL_L)VALUES (@ısbn, @title, @author, @year, @publisher, @imageS, @imageM, @imageL);";
				cmd = new MySqlCommand(query, mysqlconn);
				cmd.Parameters.AddWithValue("@ısbn", myList.ElementAt(0));
				cmd.Parameters.AddWithValue("@title", myList.ElementAt(1));
				cmd.Parameters.AddWithValue("@author", myList.ElementAt(2));
				cmd.Parameters.AddWithValue("@year", myList.ElementAt(3));
				cmd.Parameters.AddWithValue("@publisher", myList.ElementAt(4));
				cmd.Parameters.AddWithValue("@imageS", myList.ElementAt(5));
				cmd.Parameters.AddWithValue("@imageM", myList.ElementAt(6));
				cmd.Parameters.AddWithValue("@imageL", myList.ElementAt(7));

				int result2 = cmd.ExecuteNonQuery();
				//MessageBox.Show(result.ToString()); //1 dönerse işlem başarılı demektir.
			}

			progressBar1.Value = 0;
			MessageBox.Show("Kitaplar Başarıyla Veritabanına Kaydedildi!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

			/*var source = File.ReadLines(filePath).Select(line => line.Split(';'));
			foreach (var c in source)
			{
				Debug.WriteLine(c);
			}*/
			

		}

		public void RatingCsvDosya(string filePath)
		{
			MySqlCommand cmd;

			var reader = new StreamReader(File.OpenRead(filePath));
			List<string> searchList = new List<string>();
			while (!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				searchList.Add(line);
			}

			for (int i = 1; i < 501; i++) //500 kayıt
			{
				string veri = searchList.ElementAt(i);
				veri = Regex.Replace(veri, "\"", "");
				List<string> myList = veri.Split(';').ToList();
				//Debug.WriteLine(myList.ElementAt(0));

				string query = "INSERT INTO kitap_oyları(UserID, ISBN, BookRating)VALUES (@ID, @ISBN, @rating);";
				cmd = new MySqlCommand(query, mysqlconn);
				cmd.Parameters.AddWithValue("@ID", myList.ElementAt(0));
				cmd.Parameters.AddWithValue("@ISBN", myList.ElementAt(1));
				//cmd.Parameters.AddWithValue("@rating", myList.ElementAt(2));
				cmd.Parameters.AddWithValue("@rating", Int32.Parse(myList.ElementAt(2)));

				int result2 = cmd.ExecuteNonQuery();
				//MessageBox.Show(result.ToString()); //1 dönerse işlem başarılı demektir.
			}

			MessageBox.Show("Kitap Ratingleri Başarıyla Veritabanına Kaydedildi!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public GirişKayıtEkranı()
		{
			InitializeComponent();
		}

		private void Kayıt_btn_Click(object sender, EventArgs e)
		{
			MySqlCommand cmd;

			mysqlconn.Open();
			string query2 = "SELECT KullaniciAdi FROM kullanicilar WHERE KullaniciAdi=@users; ";
			cmd = new MySqlCommand(query2, mysqlconn);
			cmd.Parameters.AddWithValue("@users", KullanıcıKayıt_txt.Text.ToString());

			string result = (string)cmd.ExecuteScalar();

			if (result != null)
			{
				MessageBox.Show("HATA! Kullanıcı Adı başka biri tarafından kullanılıyor!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}
			
			else
			{
				string oy = "Vermedi";

				string query = "INSERT INTO kullanicilar(KullaniciAdi, Sifre, OyVermeDurumu)VALUES (@KullaniciAdi, @Sifre, @Durum);";
				cmd = new MySqlCommand(query, mysqlconn);
				cmd.Parameters.AddWithValue("@KullaniciAdi", KullanıcıKayıt_txt.Text.ToString());
				cmd.Parameters.AddWithValue("@Sifre", SifreKayıt_txt.Text.ToString());
				cmd.Parameters.AddWithValue("@Durum", oy);

				int result2 = cmd.ExecuteNonQuery();

				if (result2 == 1)
				{
					MessageBox.Show("Kullanıcı Kaydı Başarılı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
					var myVariable = new MySqlCommand("SELECT MAX(UserID) FROM kullanicilar", mysqlconn);
					int UserID = (int)myVariable.ExecuteScalar();
					//MessageBox.Show("ID:"+UserID.ToString());

					KullaniciCsvDosya("C:/Users/Cenk/Desktop/BX-CSV-Dump/BX-Users.csv", UserID);
					mysqlconn.Close();
				}

				else
				{
					MessageBox.Show("HATA!Kullanıcı Kaydı Başarısız!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
					mysqlconn.Close();
				}
			}
		}

		private void giris_btn_Click_1(object sender, EventArgs e)
		{

			mysqlconn.Open();
			string query = "SELECT KullaniciAdi FROM kullanicilar WHERE KullaniciAdi=@user AND Sifre=@sifre;";
			MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
			cmd.Parameters.AddWithValue("@user", KullanıcıGiris_txt.Text.ToString());
			cmd.Parameters.AddWithValue("@sifre", SifreGiris_txt.Text.ToString());

			string result = (string) cmd.ExecuteScalar();

			if (result != null)
			{
				MessageBox.Show("Giriş Başarılı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);

				//*********************************************kitap tavsiye kodları için gerekli*************************************************
				Kullanici_Adi = KullanıcıGiris_txt.Text.ToString();

				MySqlCommand Create_table = new MySqlCommand("CREATE TABLE IF NOT EXISTS " + Kullanici_Adi + "(" +
				"`ISBN` VARCHAR(50)" +
				"" +
				"" +
				"" +
				"" +
				"" +
				");", mysqlconn);
				int sonuc = Create_table.ExecuteNonQuery();

				//tablo adlarını tutmak için gerekli!
				string path = @"C:\Users\Cenk\Desktop\Proje\YazLab1-Proje\Tablolar.txt";
				if (!File.Exists(path))
				{
					File.Create(path);
				}

				File.AppendAllText(@"C:\Users\Cenk\Desktop\Proje\YazLab1-Proje\Tablolar.txt", Kullanici_Adi + Environment.NewLine);
				mysqlconn.Close();

				//**************************************************************************************************************************

				mysqlconn.Open();
				string query2 = "SELECT OyVermeDurumu FROM kullanicilar WHERE KullaniciAdi=@user AND Sifre=@sifre;";
				MySqlCommand cmd2 = new MySqlCommand(query2, mysqlconn);
				cmd2.Parameters.AddWithValue("@user", KullanıcıGiris_txt.Text.ToString());
				cmd2.Parameters.AddWithValue("@sifre", SifreGiris_txt.Text.ToString());

				string result2 = (string)cmd2.ExecuteScalar();

				if (result2.Equals("Verdi"))
				{
					mysqlconn.Close();
					this.Hide();
					AnaEkran form2 = new AnaEkran(Kullanici_Adi);
					form2.ShowDialog();
					this.Close();
				}

				else if (result2.Equals("Vermedi"))
				{
					string query3 = "SELECT UserID FROM kullanicilar WHERE KullaniciAdi=@user AND Sifre=@sifre;";
					MySqlCommand cdm3 = new MySqlCommand(query3, mysqlconn);
					cdm3.Parameters.AddWithValue("@user", KullanıcıGiris_txt.Text.ToString());
					cdm3.Parameters.AddWithValue("@sifre", SifreGiris_txt.Text.ToString());

					int result3 = (int)cdm3.ExecuteScalar();

					mysqlconn.Close();
					this.Hide();
					OyVermeFormu form = new OyVermeFormu(result3, Kullanici_Adi);
					form.ShowDialog();
					this.Close();
				}
			}

			else
			{
				MessageBox.Show("Böyle bir Kullanıcı Yok!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}
			
		}

		private void cıkıs_btn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void admin_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			YöneticiGirisi form = new YöneticiGirisi();
			form.ShowDialog();
			this.Close();
		}

		private void kitapYukle_btn_Click(object sender, EventArgs e)
		{
			KitapCsvDosya("C:/Users/Cenk/Desktop/BX-CSV-Dump/BX-Books.csv");
		}

		private void ResimIndir_btn_Click(object sender, EventArgs e)
		{
			progressBar1.Maximum = 100;
			progressBar1.Step = 1;
			progressBar1.Value = 0;

			mysqlconn.Open();
			List<string> list_url = new List<string>();
			MySqlDataReader Reader;

			try
			{
				MySqlCommand cmd = mysqlconn.CreateCommand();
				cmd.CommandText = "SELECT ImageURL_M FROM kitaplar";
				Reader = cmd.ExecuteReader();

				while (Reader.Read())
				{
					//Console.WriteLine(Reader[0].ToString());
					list_url.Add(Reader[0].ToString());
				}
				mysqlconn.Close();

			}
			catch (Exception)
			{
				Console.WriteLine("Error!!!");
				mysqlconn.Close();
			}

			mysqlconn.Open();
			List<string> list_isbn = new List<string>();
			MySqlDataReader Reader2;

			try
			{
				MySqlCommand cmd = mysqlconn.CreateCommand();
				cmd.CommandText = "SELECT ISBN FROM kitaplar";
				Reader2 = cmd.ExecuteReader();

				while (Reader2.Read())
				{
					//Console.WriteLine(Reader[0].ToString());
					list_isbn.Add(Reader2[0].ToString());
				}
				mysqlconn.Close();

			}
			catch (Exception)
			{
				Console.WriteLine("Error!!!");
				mysqlconn.Close();
			}


			progressBar1.Maximum = 100;
			progressBar1.Step = 1;
			progressBar1.Value = 0;

			for (int i = 0; i < 100; i++)
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] data = webClient.DownloadData(list_url.ElementAt(i));

					using (MemoryStream mem = new MemoryStream(data))
					{
						using (var yourImage = Image.FromStream(mem))
						{
							yourImage.Save("C:/Users/Cenk/Desktop/Kitap Resimler/" + i.ToString() + ".jpg", ImageFormat.Jpeg);
						}
					}

					mysqlconn.Open();
					progressBar1.Value = i;

					FileStream fs;
					Byte[] bindata;
					MySqlParameter picpara;
					MySqlCommand cmd = new MySqlCommand("UPDATE kitaplar SET Resim=@Resim WHERE ISBN=@ISBN;", mysqlconn);
					picpara = cmd.Parameters.Add("@Resim", MySqlDbType.MediumBlob);
					cmd.Parameters.AddWithValue("@ISBN", list_isbn.ElementAt(i));
					cmd.Prepare();

					//txtPicPath is the path of the image, e.g. C:\MyPic.png

					fs = new FileStream("C:/Users/Cenk/Desktop/Kitap Resimler/" + i.ToString() + ".jpg", FileMode.Open, FileAccess.Read);
					bindata = new byte[Convert.ToInt32(fs.Length)];
					fs.Read(bindata, 0, Convert.ToInt32(fs.Length));
					fs.Close();

					picpara.Value = bindata;
					cmd.ExecuteNonQuery();
					mysqlconn.Close();

				}
			}
			progressBar1.Value = 0;
			MessageBox.Show("Kitap İndirme Tamamlandı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
