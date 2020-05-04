namespace YazLab1_Proje
{
	partial class GirişKayıtEkranı
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.LoginPage = new System.Windows.Forms.TabPage();
			this.admin_btn = new System.Windows.Forms.Button();
			this.giris_btn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cıkıs_btn = new System.Windows.Forms.Button();
			this.SifreGiris_txt = new System.Windows.Forms.TextBox();
			this.KullanıcıGiris_txt = new System.Windows.Forms.TextBox();
			this.RegisterPage = new System.Windows.Forms.TabPage();
			this.Kayıt_btn = new System.Windows.Forms.Button();
			this.SifreKayıt_txt = new System.Windows.Forms.TextBox();
			this.KullanıcıKayıt_txt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ResimIndir_btn = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.tabControl1.SuspendLayout();
			this.LoginPage.SuspendLayout();
			this.RegisterPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.LoginPage);
			this.tabControl1.Controls.Add(this.RegisterPage);
			this.tabControl1.Location = new System.Drawing.Point(-2, 1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(588, 263);
			this.tabControl1.TabIndex = 0;
			// 
			// LoginPage
			// 
			this.LoginPage.Controls.Add(this.progressBar1);
			this.LoginPage.Controls.Add(this.ResimIndir_btn);
			this.LoginPage.Controls.Add(this.admin_btn);
			this.LoginPage.Controls.Add(this.giris_btn);
			this.LoginPage.Controls.Add(this.label2);
			this.LoginPage.Controls.Add(this.label1);
			this.LoginPage.Controls.Add(this.cıkıs_btn);
			this.LoginPage.Controls.Add(this.SifreGiris_txt);
			this.LoginPage.Controls.Add(this.KullanıcıGiris_txt);
			this.LoginPage.Location = new System.Drawing.Point(4, 25);
			this.LoginPage.Name = "LoginPage";
			this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
			this.LoginPage.Size = new System.Drawing.Size(580, 234);
			this.LoginPage.TabIndex = 0;
			this.LoginPage.Text = "Giriş Sekmesi";
			this.LoginPage.UseVisualStyleBackColor = true;
			// 
			// admin_btn
			// 
			this.admin_btn.Location = new System.Drawing.Point(377, 178);
			this.admin_btn.Name = "admin_btn";
			this.admin_btn.Size = new System.Drawing.Size(109, 33);
			this.admin_btn.TabIndex = 9;
			this.admin_btn.Text = "Yönetici Girişi";
			this.admin_btn.UseVisualStyleBackColor = true;
			this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
			// 
			// giris_btn
			// 
			this.giris_btn.Location = new System.Drawing.Point(340, 122);
			this.giris_btn.Name = "giris_btn";
			this.giris_btn.Size = new System.Drawing.Size(75, 30);
			this.giris_btn.TabIndex = 8;
			this.giris_btn.Text = "Giriş";
			this.giris_btn.UseVisualStyleBackColor = true;
			this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(363, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Şifre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(297, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// cıkıs_btn
			// 
			this.cıkıs_btn.Location = new System.Drawing.Point(439, 122);
			this.cıkıs_btn.Name = "cıkıs_btn";
			this.cıkıs_btn.Size = new System.Drawing.Size(83, 30);
			this.cıkıs_btn.TabIndex = 5;
			this.cıkıs_btn.Text = "Çıkış";
			this.cıkıs_btn.UseVisualStyleBackColor = true;
			this.cıkıs_btn.Click += new System.EventHandler(this.cıkıs_btn_Click);
			// 
			// SifreGiris_txt
			// 
			this.SifreGiris_txt.Location = new System.Drawing.Point(439, 72);
			this.SifreGiris_txt.Name = "SifreGiris_txt";
			this.SifreGiris_txt.PasswordChar = '*';
			this.SifreGiris_txt.Size = new System.Drawing.Size(100, 22);
			this.SifreGiris_txt.TabIndex = 1;
			// 
			// KullanıcıGiris_txt
			// 
			this.KullanıcıGiris_txt.Location = new System.Drawing.Point(439, 28);
			this.KullanıcıGiris_txt.Name = "KullanıcıGiris_txt";
			this.KullanıcıGiris_txt.Size = new System.Drawing.Size(100, 22);
			this.KullanıcıGiris_txt.TabIndex = 0;
			// 
			// RegisterPage
			// 
			this.RegisterPage.Controls.Add(this.Kayıt_btn);
			this.RegisterPage.Controls.Add(this.SifreKayıt_txt);
			this.RegisterPage.Controls.Add(this.KullanıcıKayıt_txt);
			this.RegisterPage.Controls.Add(this.label4);
			this.RegisterPage.Controls.Add(this.label3);
			this.RegisterPage.Location = new System.Drawing.Point(4, 25);
			this.RegisterPage.Name = "RegisterPage";
			this.RegisterPage.Padding = new System.Windows.Forms.Padding(3);
			this.RegisterPage.Size = new System.Drawing.Size(580, 234);
			this.RegisterPage.TabIndex = 1;
			this.RegisterPage.Text = "Kayıt Sekmesi";
			this.RegisterPage.UseVisualStyleBackColor = true;
			// 
			// Kayıt_btn
			// 
			this.Kayıt_btn.Location = new System.Drawing.Point(335, 141);
			this.Kayıt_btn.Name = "Kayıt_btn";
			this.Kayıt_btn.Size = new System.Drawing.Size(86, 32);
			this.Kayıt_btn.TabIndex = 5;
			this.Kayıt_btn.Text = "Kayıt Ol";
			this.Kayıt_btn.UseVisualStyleBackColor = true;
			this.Kayıt_btn.Click += new System.EventHandler(this.Kayıt_btn_Click);
			// 
			// SifreKayıt_txt
			// 
			this.SifreKayıt_txt.Location = new System.Drawing.Point(335, 93);
			this.SifreKayıt_txt.Name = "SifreKayıt_txt";
			this.SifreKayıt_txt.PasswordChar = '*';
			this.SifreKayıt_txt.Size = new System.Drawing.Size(100, 22);
			this.SifreKayıt_txt.TabIndex = 4;
			// 
			// KullanıcıKayıt_txt
			// 
			this.KullanıcıKayıt_txt.Location = new System.Drawing.Point(335, 45);
			this.KullanıcıKayıt_txt.Name = "KullanıcıKayıt_txt";
			this.KullanıcıKayıt_txt.Size = new System.Drawing.Size(100, 22);
			this.KullanıcıKayıt_txt.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(262, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 24);
			this.label4.TabIndex = 1;
			this.label4.Text = "Şifre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(196, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 24);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kullanıcı Adı:";
			// 
			// ResimIndir_btn
			// 
			this.ResimIndir_btn.Location = new System.Drawing.Point(10, 178);
			this.ResimIndir_btn.Name = "ResimIndir_btn";
			this.ResimIndir_btn.Size = new System.Drawing.Size(116, 33);
			this.ResimIndir_btn.TabIndex = 10;
			this.ResimIndir_btn.Text = "Resimleri İndir";
			this.ResimIndir_btn.UseVisualStyleBackColor = true;
			this.ResimIndir_btn.Click += new System.EventHandler(this.ResimIndir_btn_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(153, 178);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(100, 33);
			this.progressBar1.TabIndex = 11;
			// 
			// GirişKayıtEkranı
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 266);
			this.Controls.Add(this.tabControl1);
			this.Name = "GirişKayıtEkranı";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.LoginPage.ResumeLayout(false);
			this.LoginPage.PerformLayout();
			this.RegisterPage.ResumeLayout(false);
			this.RegisterPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage LoginPage;
		private System.Windows.Forms.TabPage RegisterPage;
		private System.Windows.Forms.TextBox SifreGiris_txt;
		private System.Windows.Forms.TextBox KullanıcıGiris_txt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cıkıs_btn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox SifreKayıt_txt;
		private System.Windows.Forms.TextBox KullanıcıKayıt_txt;
		private System.Windows.Forms.Button Kayıt_btn;
		private System.Windows.Forms.Button giris_btn;
		private System.Windows.Forms.Button admin_btn;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button ResimIndir_btn;
	}
}

