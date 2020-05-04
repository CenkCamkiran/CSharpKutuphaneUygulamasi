namespace YazLab1_Proje
{
	partial class EnIyiKitapGoster
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
			this.EnIyiKitapFormu_View = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.EnIyiKitapFormu_View)).BeginInit();
			this.SuspendLayout();
			// 
			// EnIyiKitapFormu_View
			// 
			this.EnIyiKitapFormu_View.AllowUserToAddRows = false;
			this.EnIyiKitapFormu_View.AllowUserToDeleteRows = false;
			this.EnIyiKitapFormu_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.EnIyiKitapFormu_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EnIyiKitapFormu_View.Location = new System.Drawing.Point(12, 120);
			this.EnIyiKitapFormu_View.Name = "EnIyiKitapFormu_View";
			this.EnIyiKitapFormu_View.ReadOnly = true;
			this.EnIyiKitapFormu_View.RowTemplate.Height = 24;
			this.EnIyiKitapFormu_View.Size = new System.Drawing.Size(1049, 238);
			this.EnIyiKitapFormu_View.TabIndex = 0;
			this.EnIyiKitapFormu_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnIyiKitapFormu_View_CellClick);
			// 
			// EnIyiKitapGoster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 370);
			this.Controls.Add(this.EnIyiKitapFormu_View);
			this.Name = "EnIyiKitapGoster";
			this.Text = "Kitap Göster";
			((System.ComponentModel.ISupportInitialize)(this.EnIyiKitapFormu_View)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView EnIyiKitapFormu_View;
	}
}