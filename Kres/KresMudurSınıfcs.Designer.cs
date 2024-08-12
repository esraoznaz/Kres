namespace Kres
{
	partial class KresMudurSınıfcs
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button_aktifSınıf = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(80, 57);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(945, 330);
			this.dataGridView1.TabIndex = 0;
			// 
			// button_aktifSınıf
			// 
			this.button_aktifSınıf.Location = new System.Drawing.Point(457, 405);
			this.button_aktifSınıf.Name = "button_aktifSınıf";
			this.button_aktifSınıf.Size = new System.Drawing.Size(232, 70);
			this.button_aktifSınıf.TabIndex = 1;
			this.button_aktifSınıf.Text = "Aktif Sınıf";
			this.button_aktifSınıf.UseVisualStyleBackColor = true;
			this.button_aktifSınıf.Click += new System.EventHandler(this.button_aktifSınıf_Click);
			// 
			// KresMudurSınıfcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1124, 487);
			this.Controls.Add(this.button_aktifSınıf);
			this.Controls.Add(this.dataGridView1);
			this.Name = "KresMudurSınıfcs";
			this.Text = "KresMudurSınıfcs";
			this.Load += new System.EventHandler(this.KresMudurSınıfcs_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_aktifSınıf;
	}
}