namespace YazLab1_Proje
{
	partial class OyVermeFormu
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
			this.KitaplarView = new System.Windows.Forms.DataGridView();
			this.OyVer_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.OyCik_btn = new System.Windows.Forms.Button();
			this.geri_btn6 = new System.Windows.Forms.Button();
			this.ileri_btn6 = new System.Windows.Forms.Button();
			this.ISBN_txtbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.OyVermeSkalası = new System.Windows.Forms.NumericUpDown();
			this.OyVermeSayisi_txt = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.KitaplarView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OyVermeSkalası)).BeginInit();
			this.SuspendLayout();
			// 
			// KitaplarView
			// 
			this.KitaplarView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.KitaplarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.KitaplarView.Location = new System.Drawing.Point(12, 114);
			this.KitaplarView.Name = "KitaplarView";
			this.KitaplarView.RowTemplate.Height = 24;
			this.KitaplarView.Size = new System.Drawing.Size(1142, 424);
			this.KitaplarView.TabIndex = 0;
			// 
			// OyVer_btn
			// 
			this.OyVer_btn.Location = new System.Drawing.Point(267, 66);
			this.OyVer_btn.Name = "OyVer_btn";
			this.OyVer_btn.Size = new System.Drawing.Size(75, 35);
			this.OyVer_btn.TabIndex = 2;
			this.OyVer_btn.Text = "Oy Ver";
			this.OyVer_btn.UseVisualStyleBackColor = true;
			this.OyVer_btn.Click += new System.EventHandler(this.OyVer_btn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(74, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Oy:";
			// 
			// OyCik_btn
			// 
			this.OyCik_btn.Location = new System.Drawing.Point(366, 66);
			this.OyCik_btn.Name = "OyCik_btn";
			this.OyCik_btn.Size = new System.Drawing.Size(76, 35);
			this.OyCik_btn.TabIndex = 4;
			this.OyCik_btn.Text = "Çık";
			this.OyCik_btn.UseVisualStyleBackColor = true;
			this.OyCik_btn.Click += new System.EventHandler(this.OyCik_btn_Click);
			// 
			// geri_btn6
			// 
			this.geri_btn6.Location = new System.Drawing.Point(947, 81);
			this.geri_btn6.Name = "geri_btn6";
			this.geri_btn6.Size = new System.Drawing.Size(75, 27);
			this.geri_btn6.TabIndex = 5;
			this.geri_btn6.Text = "Geri";
			this.geri_btn6.UseVisualStyleBackColor = true;
			this.geri_btn6.Click += new System.EventHandler(this.geri_btn6_Click);
			// 
			// ileri_btn6
			// 
			this.ileri_btn6.Location = new System.Drawing.Point(1043, 81);
			this.ileri_btn6.Name = "ileri_btn6";
			this.ileri_btn6.Size = new System.Drawing.Size(75, 27);
			this.ileri_btn6.TabIndex = 6;
			this.ileri_btn6.Text = "İleri";
			this.ileri_btn6.UseVisualStyleBackColor = true;
			this.ileri_btn6.Click += new System.EventHandler(this.ileri_btn6_Click);
			// 
			// ISBN_txtbox
			// 
			this.ISBN_txtbox.Location = new System.Drawing.Point(138, 24);
			this.ISBN_txtbox.Name = "ISBN_txtbox";
			this.ISBN_txtbox.Size = new System.Drawing.Size(100, 22);
			this.ISBN_txtbox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(54, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "ISBN:";
			// 
			// OyVermeSkalası
			// 
			this.OyVermeSkalası.Location = new System.Drawing.Point(138, 72);
			this.OyVermeSkalası.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.OyVermeSkalası.Name = "OyVermeSkalası";
			this.OyVermeSkalası.Size = new System.Drawing.Size(46, 22);
			this.OyVermeSkalası.TabIndex = 10;
			// 
			// OyVermeSayisi_txt
			// 
			this.OyVermeSayisi_txt.AutoSize = true;
			this.OyVermeSayisi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.OyVermeSayisi_txt.Location = new System.Drawing.Point(584, 26);
			this.OyVermeSayisi_txt.Name = "OyVermeSayisi_txt";
			this.OyVermeSayisi_txt.Size = new System.Drawing.Size(0, 20);
			this.OyVermeSayisi_txt.TabIndex = 11;
			// 
			// OyVermeFormu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 550);
			this.Controls.Add(this.OyVermeSayisi_txt);
			this.Controls.Add(this.OyVermeSkalası);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ISBN_txtbox);
			this.Controls.Add(this.ileri_btn6);
			this.Controls.Add(this.geri_btn6);
			this.Controls.Add(this.OyCik_btn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OyVer_btn);
			this.Controls.Add(this.KitaplarView);
			this.Name = "OyVermeFormu";
			this.Text = "OyVermeFormu";
			((System.ComponentModel.ISupportInitialize)(this.KitaplarView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OyVermeSkalası)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView KitaplarView;
		private System.Windows.Forms.Button OyVer_btn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OyCik_btn;
		private System.Windows.Forms.Button geri_btn6;
		private System.Windows.Forms.Button ileri_btn6;
		private System.Windows.Forms.TextBox ISBN_txtbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown OyVermeSkalası;
		private System.Windows.Forms.Label OyVermeSayisi_txt;
	}
}