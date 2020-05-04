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
	public partial class YöneticiGirisi : Form
	{
		MySqlConnection mysqlconn = new MySqlConnection("server=localhost;database=users;Uid=root;Pwd=;SslMode=none");

		public YöneticiGirisi()
		{
			InitializeComponent();
		}

		private void önceki_btn_Click(object sender, EventArgs e)
		{
			this.Hide();
			GirişKayıtEkranı form = new GirişKayıtEkranı();
			form.ShowDialog();
			this.Close();
		}

		private void adminGrs_btn_Click(object sender, EventArgs e)
		{
			mysqlconn.Open();
			string query = "SELECT AdminAdi FROM yöneticiler WHERE AdminAdi=@admin AND AdminSifre=@sifre;";
			MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
			cmd.Parameters.AddWithValue("@admin", admin_txt.Text.ToString());
			cmd.Parameters.AddWithValue("@sifre", sifre_txt.Text.ToString());

			string result = (string)cmd.ExecuteScalar();

			if (result != null)
			{
				MessageBox.Show("Yönetici Girişi Başarılı!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
				mysqlconn.Close();
				this.Hide();
				YöneticiPaneli form = new YöneticiPaneli();
				form.ShowDialog();
				this.Close();
			}

			else
			{
				MessageBox.Show("Böyle bir Yönetici Yok!", "SİSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				mysqlconn.Close();
			}
		}
	}
}
