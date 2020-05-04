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
	public partial class PDFFormu : Form
	{
		public PDFFormu(string pdfSource)
		{
			InitializeComponent();
			axAcroPDF2.src = pdfSource;
		}
	}
}
