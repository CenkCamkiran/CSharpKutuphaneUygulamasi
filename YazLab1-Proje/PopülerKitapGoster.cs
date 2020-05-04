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
	public partial class PopülerKitapGoster : Form
	{
		MySqlConnection mysqlconn = new MySqlConnection("server=localhost;database=users;Uid=root;Pwd=;SslMode=none");
		DataTable dt = new DataTable();

		public PopülerKitapGoster(string ISBN)
		{
			InitializeComponent();
			KitapGoster(ISBN);
		}

		public void KitapGoster(string ISBN)
		{

			try
			{
				string query = "SELECT ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, KitapPDF_Yol, Resim FROM kitaplar WHERE ISBN=@ISBN";
				mysqlconn.Open();

				MySqlCommand cmd = new MySqlCommand(query, mysqlconn);
				cmd.Parameters.AddWithValue("@ISBN", ISBN);

				MySqlDataAdapter mysqldataAdapter = new MySqlDataAdapter(cmd);
				mysqldataAdapter.Fill(dt);

				MySqlCommandBuilder mysqlcommandBuilder = new MySqlCommandBuilder(mysqldataAdapter);

				PopülerKitapFormu_View.DataSource = dt;
				PopülerKitapFormu_View.DataMember = dt.TableName;
				PopülerKitapFormu_View.AutoResizeColumns();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void PopülerKitapFormu_View_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell cell = (DataGridViewCell)PopülerKitapFormu_View.Rows[e.RowIndex].Cells[e.ColumnIndex];

			if (cell.ColumnIndex == this.PopülerKitapFormu_View.Columns["KitapPDF_Yol"].Index)
			{
				// Do something when a "YourColumn" cell is clicked 
				//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());

				//MessageBox.Show(ofd.FileName.GetType().ToString());// yolu yazıyor
				//axAcroPDF1.src = ofd.FileName; pdf görüntülüyor.
				if (PopülerKitapFormu_View.SelectedCells[0].Value.ToString() == "")
				{
					MessageBox.Show("Tıkladığınız kitabın PDF'i bulunmamaktadır. Lütfen Yöneticinizle iletişime geçin!", "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				else
				{
					//MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString()); //kitabın yolunu gösteriyor sıkıntı yok!
					PDFFormu form = new PDFFormu(PopülerKitapFormu_View.SelectedCells[0].Value.ToString());
					form.TopMost = true;
					form.Show();
				}

			}
		}
	}
}
