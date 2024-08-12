namespace Kres
{
	partial class YetkiliYetkililer
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
			this.button_kaydet = new System.Windows.Forms.Button();
			this.button_guncelle = new System.Windows.Forms.Button();
			this.button_aktifYetkili = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 21);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1071, 244);
			this.dataGridView1.TabIndex = 0;
			// 
			// button_kaydet
			// 
			this.button_kaydet.Location = new System.Drawing.Point(61, 293);
			this.button_kaydet.Name = "button_kaydet";
			this.button_kaydet.Size = new System.Drawing.Size(261, 67);
			this.button_kaydet.TabIndex = 1;
			this.button_kaydet.Text = "Yetkili Ekle";
			this.button_kaydet.UseVisualStyleBackColor = true;
			this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
			// 
			// button_guncelle
			// 
			this.button_guncelle.Location = new System.Drawing.Point(386, 293);
			this.button_guncelle.Name = "button_guncelle";
			this.button_guncelle.Size = new System.Drawing.Size(261, 67);
			this.button_guncelle.TabIndex = 2;
			this.button_guncelle.Text = "Güncelle";
			this.button_guncelle.UseVisualStyleBackColor = true;
			this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
			// 
			// button_aktifYetkili
			// 
			this.button_aktifYetkili.Location = new System.Drawing.Point(715, 293);
			this.button_aktifYetkili.Name = "button_aktifYetkili";
			this.button_aktifYetkili.Size = new System.Drawing.Size(261, 67);
			this.button_aktifYetkili.TabIndex = 3;
			this.button_aktifYetkili.Text = "Aktif Yetkili ";
			this.button_aktifYetkili.UseVisualStyleBackColor = true;
			this.button_aktifYetkili.Click += new System.EventHandler(this.button_aktifYetkili_Click);
			// 
			// YetkiliYetkililer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 387);
			this.Controls.Add(this.button_aktifYetkili);
			this.Controls.Add(this.button_guncelle);
			this.Controls.Add(this.button_kaydet);
			this.Controls.Add(this.dataGridView1);
			this.Name = "YetkiliYetkililer";
			this.Text = "YetkiliYetkililer";
			this.Load += new System.EventHandler(this.YetkiliYetkililer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_kaydet;
		private System.Windows.Forms.Button button_guncelle;
		private System.Windows.Forms.Button button_aktifYetkili;
	}
}