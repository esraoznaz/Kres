namespace Kres
{
	partial class Kres_Mudur_Ogrenci
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
			this.button_ekle = new System.Windows.Forms.Button();
			this.button_güncelle = new System.Windows.Forms.Button();
			this.button_aktifOgrenci = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1476, 336);
			this.dataGridView1.TabIndex = 0;
			// 
			// button_ekle
			// 
			this.button_ekle.Location = new System.Drawing.Point(167, 396);
			this.button_ekle.Name = "button_ekle";
			this.button_ekle.Size = new System.Drawing.Size(307, 72);
			this.button_ekle.TabIndex = 1;
			this.button_ekle.Text = "Öğrenci Ekle";
			this.button_ekle.UseVisualStyleBackColor = true;
			this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
			// 
			// button_güncelle
			// 
			this.button_güncelle.Location = new System.Drawing.Point(617, 396);
			this.button_güncelle.Name = "button_güncelle";
			this.button_güncelle.Size = new System.Drawing.Size(307, 72);
			this.button_güncelle.TabIndex = 2;
			this.button_güncelle.Text = "Bilgileri Güncelle";
			this.button_güncelle.UseVisualStyleBackColor = true;
			this.button_güncelle.Click += new System.EventHandler(this.button_güncelle_Click);
			// 
			// button_aktifOgrenci
			// 
			this.button_aktifOgrenci.Location = new System.Drawing.Point(1044, 396);
			this.button_aktifOgrenci.Name = "button_aktifOgrenci";
			this.button_aktifOgrenci.Size = new System.Drawing.Size(307, 72);
			this.button_aktifOgrenci.TabIndex = 3;
			this.button_aktifOgrenci.Text = "Aktif Öğrenci ";
			this.button_aktifOgrenci.UseVisualStyleBackColor = true;
			this.button_aktifOgrenci.Click += new System.EventHandler(this.button_aktifOgrenci_Click);
			// 
			// Kres_Mudur_Ogrenci
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1500, 504);
			this.Controls.Add(this.button_aktifOgrenci);
			this.Controls.Add(this.button_güncelle);
			this.Controls.Add(this.button_ekle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Kres_Mudur_Ogrenci";
			this.Text = "Kres_Mudur_Ogrenci";
			this.Load += new System.EventHandler(this.Kres_Mudur_Ogrenci_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_ekle;
		private System.Windows.Forms.Button button_güncelle;
		private System.Windows.Forms.Button button_aktifOgrenci;
	}
}