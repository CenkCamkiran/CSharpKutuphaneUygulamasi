namespace YazLab1_Proje
{
	partial class AnaEkran
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.goster_btn = new System.Windows.Forms.Button();
			this.KitapTavsiyeView = new System.Windows.Forms.DataGridView();
			this.YeniKitapTab = new System.Windows.Forms.TabPage();
			this.Yenile_btn6 = new System.Windows.Forms.Button();
			this.YeniKitapView = new System.Windows.Forms.DataGridView();
			this.PopulerTab = new System.Windows.Forms.TabPage();
			this.PopulerKitapView = new System.Windows.Forms.DataGridView();
			this.EnIyiKitapTab = new System.Windows.Forms.TabPage();
			this.EnIyi10Kitap_View = new System.Windows.Forms.DataGridView();
			this.TumKitapTab = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.ISBN_txtbox2 = new System.Windows.Forms.TextBox();
			this.begen_btn = new System.Windows.Forms.Button();
			this.geri_btn = new System.Windows.Forms.Button();
			this.ileri_btn = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.KitapTavsiyeView)).BeginInit();
			this.YeniKitapTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.YeniKitapView)).BeginInit();
			this.PopulerTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PopulerKitapView)).BeginInit();
			this.EnIyiKitapTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EnIyi10Kitap_View)).BeginInit();
			this.TumKitapTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.goster_btn);
			this.tabPage1.Controls.Add(this.KitapTavsiyeView);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1214, 619);
			this.tabPage1.TabIndex = 4;
			this.tabPage1.Text = "Kitap Tavsiyesi";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// goster_btn
			// 
			this.goster_btn.Location = new System.Drawing.Point(551, 99);
			this.goster_btn.Name = "goster_btn";
			this.goster_btn.Size = new System.Drawing.Size(75, 38);
			this.goster_btn.TabIndex = 1;
			this.goster_btn.Text = "Göster";
			this.goster_btn.UseVisualStyleBackColor = true;
			this.goster_btn.Click += new System.EventHandler(this.goster_btn_Click);
			// 
			// KitapTavsiyeView
			// 
			this.KitapTavsiyeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.KitapTavsiyeView.Location = new System.Drawing.Point(119, 156);
			this.KitapTavsiyeView.Name = "KitapTavsiyeView";
			this.KitapTavsiyeView.RowTemplate.Height = 24;
			this.KitapTavsiyeView.Size = new System.Drawing.Size(968, 377);
			this.KitapTavsiyeView.TabIndex = 0;
			this.KitapTavsiyeView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KitapTavsiyeView_CellClick);
			// 
			// YeniKitapTab
			// 
			this.YeniKitapTab.Controls.Add(this.Yenile_btn6);
			this.YeniKitapTab.Controls.Add(this.YeniKitapView);
			this.YeniKitapTab.Location = new System.Drawing.Point(4, 25);
			this.YeniKitapTab.Name = "YeniKitapTab";
			this.YeniKitapTab.Size = new System.Drawing.Size(1214, 619);
			this.YeniKitapTab.TabIndex = 2;
			this.YeniKitapTab.Text = "Yeni Kitaplar";
			this.YeniKitapTab.UseVisualStyleBackColor = true;
			// 
			// Yenile_btn6
			// 
			this.Yenile_btn6.Location = new System.Drawing.Point(547, 149);
			this.Yenile_btn6.Name = "Yenile_btn6";
			this.Yenile_btn6.Size = new System.Drawing.Size(75, 39);
			this.Yenile_btn6.TabIndex = 1;
			this.Yenile_btn6.Text = "Yenile";
			this.Yenile_btn6.UseVisualStyleBackColor = true;
			this.Yenile_btn6.Click += new System.EventHandler(this.Yenile_btn6_Click);
			// 
			// YeniKitapView
			// 
			this.YeniKitapView.AllowUserToAddRows = false;
			this.YeniKitapView.AllowUserToDeleteRows = false;
			this.YeniKitapView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.YeniKitapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.YeniKitapView.Location = new System.Drawing.Point(88, 205);
			this.YeniKitapView.Name = "YeniKitapView";
			this.YeniKitapView.ReadOnly = true;
			this.YeniKitapView.RowTemplate.Height = 24;
			this.YeniKitapView.Size = new System.Drawing.Size(1038, 404);
			this.YeniKitapView.TabIndex = 0;
			this.YeniKitapView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YeniKitapView_CellClick);
			// 
			// PopulerTab
			// 
			this.PopulerTab.Controls.Add(this.PopulerKitapView);
			this.PopulerTab.Location = new System.Drawing.Point(4, 25);
			this.PopulerTab.Name = "PopulerTab";
			this.PopulerTab.Padding = new System.Windows.Forms.Padding(3);
			this.PopulerTab.Size = new System.Drawing.Size(1214, 619);
			this.PopulerTab.TabIndex = 1;
			this.PopulerTab.Text = "Popüler Kitaplar";
			this.PopulerTab.UseVisualStyleBackColor = true;
			// 
			// PopulerKitapView
			// 
			this.PopulerKitapView.AllowUserToAddRows = false;
			this.PopulerKitapView.AllowUserToDeleteRows = false;
			this.PopulerKitapView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.PopulerKitapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PopulerKitapView.Location = new System.Drawing.Point(120, 162);
			this.PopulerKitapView.Name = "PopulerKitapView";
			this.PopulerKitapView.ReadOnly = true;
			this.PopulerKitapView.RowTemplate.Height = 24;
			this.PopulerKitapView.Size = new System.Drawing.Size(961, 291);
			this.PopulerKitapView.TabIndex = 0;
			this.PopulerKitapView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PopulerKitapView_CellClick);
			// 
			// EnIyiKitapTab
			// 
			this.EnIyiKitapTab.Controls.Add(this.EnIyi10Kitap_View);
			this.EnIyiKitapTab.Location = new System.Drawing.Point(4, 25);
			this.EnIyiKitapTab.Name = "EnIyiKitapTab";
			this.EnIyiKitapTab.Padding = new System.Windows.Forms.Padding(3);
			this.EnIyiKitapTab.Size = new System.Drawing.Size(1214, 619);
			this.EnIyiKitapTab.TabIndex = 0;
			this.EnIyiKitapTab.Text = "En iyi Kitaplar";
			this.EnIyiKitapTab.UseVisualStyleBackColor = true;
			// 
			// EnIyi10Kitap_View
			// 
			this.EnIyi10Kitap_View.AllowUserToDeleteRows = false;
			this.EnIyi10Kitap_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.EnIyi10Kitap_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EnIyi10Kitap_View.Location = new System.Drawing.Point(106, 174);
			this.EnIyi10Kitap_View.Name = "EnIyi10Kitap_View";
			this.EnIyi10Kitap_View.ReadOnly = true;
			this.EnIyi10Kitap_View.RowTemplate.Height = 24;
			this.EnIyi10Kitap_View.Size = new System.Drawing.Size(961, 309);
			this.EnIyi10Kitap_View.TabIndex = 0;
			this.EnIyi10Kitap_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnIyi10Kitap_View_CellClick);
			// 
			// TumKitapTab
			// 
			this.TumKitapTab.Controls.Add(this.label1);
			this.TumKitapTab.Controls.Add(this.ISBN_txtbox2);
			this.TumKitapTab.Controls.Add(this.begen_btn);
			this.TumKitapTab.Controls.Add(this.geri_btn);
			this.TumKitapTab.Controls.Add(this.ileri_btn);
			this.TumKitapTab.Controls.Add(this.dataGridView1);
			this.TumKitapTab.Location = new System.Drawing.Point(4, 25);
			this.TumKitapTab.Name = "TumKitapTab";
			this.TumKitapTab.Size = new System.Drawing.Size(1214, 619);
			this.TumKitapTab.TabIndex = 3;
			this.TumKitapTab.Text = "Tüm Kitaplar";
			this.TumKitapTab.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(71, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "ISBN:";
			// 
			// ISBN_txtbox2
			// 
			this.ISBN_txtbox2.Location = new System.Drawing.Point(149, 47);
			this.ISBN_txtbox2.Name = "ISBN_txtbox2";
			this.ISBN_txtbox2.Size = new System.Drawing.Size(135, 22);
			this.ISBN_txtbox2.TabIndex = 6;
			// 
			// begen_btn
			// 
			this.begen_btn.Location = new System.Drawing.Point(308, 42);
			this.begen_btn.Name = "begen_btn";
			this.begen_btn.Size = new System.Drawing.Size(75, 32);
			this.begen_btn.TabIndex = 5;
			this.begen_btn.Text = "Beğen";
			this.begen_btn.UseVisualStyleBackColor = true;
			this.begen_btn.Click += new System.EventHandler(this.begen_btn_Click);
			// 
			// geri_btn
			// 
			this.geri_btn.Location = new System.Drawing.Point(467, 106);
			this.geri_btn.Name = "geri_btn";
			this.geri_btn.Size = new System.Drawing.Size(75, 46);
			this.geri_btn.TabIndex = 4;
			this.geri_btn.Text = "geri";
			this.geri_btn.UseVisualStyleBackColor = true;
			this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click_1);
			// 
			// ileri_btn
			// 
			this.ileri_btn.Location = new System.Drawing.Point(595, 108);
			this.ileri_btn.Name = "ileri_btn";
			this.ileri_btn.Size = new System.Drawing.Size(75, 44);
			this.ileri_btn.TabIndex = 3;
			this.ileri_btn.Text = "ileri";
			this.ileri_btn.UseVisualStyleBackColor = true;
			this.ileri_btn.Click += new System.EventHandler(this.ileri_btn_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(62, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1051, 431);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TumKitapTab);
			this.tabControl1.Controls.Add(this.EnIyiKitapTab);
			this.tabControl1.Controls.Add(this.PopulerTab);
			this.tabControl1.Controls.Add(this.YeniKitapTab);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(-1, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1222, 648);
			this.tabControl1.TabIndex = 3;
			// 
			// AnaEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1218, 646);
			this.Controls.Add(this.tabControl1);
			this.Name = "AnaEkran";
			this.Text = "Form2";
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.KitapTavsiyeView)).EndInit();
			this.YeniKitapTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.YeniKitapView)).EndInit();
			this.PopulerTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PopulerKitapView)).EndInit();
			this.EnIyiKitapTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.EnIyi10Kitap_View)).EndInit();
			this.TumKitapTab.ResumeLayout(false);
			this.TumKitapTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button goster_btn;
		private System.Windows.Forms.DataGridView KitapTavsiyeView;
		private System.Windows.Forms.TabPage YeniKitapTab;
		private System.Windows.Forms.Button Yenile_btn6;
		private System.Windows.Forms.DataGridView YeniKitapView;
		private System.Windows.Forms.TabPage PopulerTab;
		private System.Windows.Forms.DataGridView PopulerKitapView;
		private System.Windows.Forms.TabPage EnIyiKitapTab;
		private System.Windows.Forms.DataGridView EnIyi10Kitap_View;
		private System.Windows.Forms.TabPage TumKitapTab;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ISBN_txtbox2;
		private System.Windows.Forms.Button begen_btn;
		private System.Windows.Forms.Button geri_btn;
		private System.Windows.Forms.Button ileri_btn;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}