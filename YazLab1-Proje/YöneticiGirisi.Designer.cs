namespace YazLab1_Proje
{
	partial class YöneticiGirisi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.adminGrs_btn = new System.Windows.Forms.Button();
			this.admin_txt = new System.Windows.Forms.TextBox();
			this.sifre_txt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.önceki_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// adminGrs_btn
			// 
			this.adminGrs_btn.Location = new System.Drawing.Point(142, 163);
			this.adminGrs_btn.Name = "adminGrs_btn";
			this.adminGrs_btn.Size = new System.Drawing.Size(75, 30);
			this.adminGrs_btn.TabIndex = 0;
			this.adminGrs_btn.Text = "Giriş";
			this.adminGrs_btn.UseVisualStyleBackColor = true;
			this.adminGrs_btn.Click += new System.EventHandler(this.adminGrs_btn_Click);
			// 
			// admin_txt
			// 
			this.admin_txt.Location = new System.Drawing.Point(239, 59);
			this.admin_txt.Name = "admin_txt";
			this.admin_txt.Size = new System.Drawing.Size(100, 22);
			this.admin_txt.TabIndex = 1;
			// 
			// sifre_txt
			// 
			this.sifre_txt.Location = new System.Drawing.Point(239, 109);
			this.sifre_txt.Name = "sifre_txt";
			this.sifre_txt.PasswordChar = '*';
			this.sifre_txt.Size = new System.Drawing.Size(100, 22);
			this.sifre_txt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(113, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Yönetici Adı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(176, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Şifre:";
			// 
			// önceki_btn
			// 
			this.önceki_btn.Location = new System.Drawing.Point(239, 163);
			this.önceki_btn.Name = "önceki_btn";
			this.önceki_btn.Size = new System.Drawing.Size(110, 30);
			this.önceki_btn.TabIndex = 5;
			this.önceki_btn.Text = "Önceki Sayfa";
			this.önceki_btn.UseVisualStyleBackColor = true;
			this.önceki_btn.Click += new System.EventHandler(this.önceki_btn_Click);
			// 
			// YöneticiGirisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 253);
			this.Controls.Add(this.önceki_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sifre_txt);
			this.Controls.Add(this.admin_txt);
			this.Controls.Add(this.adminGrs_btn);
			this.Name = "YöneticiGirisi";
			this.Text = "YöneticiGirisi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button adminGrs_btn;
		private System.Windows.Forms.TextBox admin_txt;
		private System.Windows.Forms.TextBox sifre_txt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button önceki_btn;
	}
}