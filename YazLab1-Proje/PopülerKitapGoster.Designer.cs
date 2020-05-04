namespace YazLab1_Proje
{
	partial class PopülerKitapGoster
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
			this.PopülerKitapFormu_View = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.PopülerKitapFormu_View)).BeginInit();
			this.SuspendLayout();
			// 
			// PopülerKitapFormu_View
			// 
			this.PopülerKitapFormu_View.AllowUserToAddRows = false;
			this.PopülerKitapFormu_View.AllowUserToDeleteRows = false;
			this.PopülerKitapFormu_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.PopülerKitapFormu_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PopülerKitapFormu_View.Location = new System.Drawing.Point(12, 126);
			this.PopülerKitapFormu_View.Name = "PopülerKitapFormu_View";
			this.PopülerKitapFormu_View.ReadOnly = true;
			this.PopülerKitapFormu_View.RowTemplate.Height = 24;
			this.PopülerKitapFormu_View.Size = new System.Drawing.Size(1007, 231);
			this.PopülerKitapFormu_View.TabIndex = 0;
			this.PopülerKitapFormu_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PopülerKitapFormu_View_CellClick);
			// 
			// PopülerKitapGoster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 369);
			this.Controls.Add(this.PopülerKitapFormu_View);
			this.Name = "PopülerKitapGoster";
			this.Text = "PopülerKitapGoster";
			((System.ComponentModel.ISupportInitialize)(this.PopülerKitapFormu_View)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView PopülerKitapFormu_View;
	}
}