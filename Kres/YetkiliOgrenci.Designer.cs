namespace Kres
{
	partial class YetkiliOgrenci
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
			this.button_Ekle = new System.Windows.Forms.Button();
			this.button_Guncelle = new System.Windows.Forms.Button();
			this.button_aktifOgr = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(28, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1839, 303);
			this.dataGridView1.TabIndex = 0;
			// 
			// button_Ekle
			// 
			this.button_Ekle.Location = new System.Drawing.Point(244, 337);
			this.button_Ekle.Name = "button_Ekle";
			this.button_Ekle.Size = new System.Drawing.Size(378, 101);
			this.button_Ekle.TabIndex = 1;
			this.button_Ekle.Text = "Öğrenci Ekle";
			this.button_Ekle.UseVisualStyleBackColor = true;
			this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
			// 
			// button_Guncelle
			// 
			this.button_Guncelle.Location = new System.Drawing.Point(707, 337);
			this.button_Guncelle.Name = "button_Guncelle";
			this.button_Guncelle.Size = new System.Drawing.Size(378, 101);
			this.button_Guncelle.TabIndex = 2;
			this.button_Guncelle.Text = "Öğrenci Güncelle";
			this.button_Guncelle.UseVisualStyleBackColor = true;
			this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
			// 
			// button_aktifOgr
			// 
			this.button_aktifOgr.Location = new System.Drawing.Point(1162, 337);
			this.button_aktifOgr.Name = "button_aktifOgr";
			this.button_aktifOgr.Size = new System.Drawing.Size(378, 101);
			this.button_aktifOgr.TabIndex = 3;
			this.button_aktifOgr.Text = "Aktif Öğrenci ";
			this.button_aktifOgr.UseVisualStyleBackColor = true;
			this.button_aktifOgr.Click += new System.EventHandler(this.button_aktifOgr_Click);
			// 
			// YetkiliOgrenci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1911, 450);
			this.Controls.Add(this.button_aktifOgr);
			this.Controls.Add(this.button_Guncelle);
			this.Controls.Add(this.button_Ekle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "YetkiliOgrenci";
			this.Text = "YetkiliOgrenci";
			this.Load += new System.EventHandler(this.YetkiliOgrenci_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_Ekle;
		private System.Windows.Forms.Button button_Guncelle;
		private System.Windows.Forms.Button button_aktifOgr;
	}
}