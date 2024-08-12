namespace Kres
{
	partial class YetkiliKres
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
			this.buttonKresEkle = new System.Windows.Forms.Button();
			this.button_Güncelle = new System.Windows.Forms.Button();
			this.button_aktifKres = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(986, 324);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// buttonKresEkle
			// 
			this.buttonKresEkle.Location = new System.Drawing.Point(12, 354);
			this.buttonKresEkle.Name = "buttonKresEkle";
			this.buttonKresEkle.Size = new System.Drawing.Size(297, 83);
			this.buttonKresEkle.TabIndex = 1;
			this.buttonKresEkle.Text = "Kreş Ekle";
			this.buttonKresEkle.UseVisualStyleBackColor = true;
			this.buttonKresEkle.Click += new System.EventHandler(this.buttonKresEkle_Click);
			// 
			// button_Güncelle
			// 
			this.button_Güncelle.Location = new System.Drawing.Point(350, 354);
			this.button_Güncelle.Name = "button_Güncelle";
			this.button_Güncelle.Size = new System.Drawing.Size(297, 83);
			this.button_Güncelle.TabIndex = 2;
			this.button_Güncelle.Text = "Güncelle";
			this.button_Güncelle.UseVisualStyleBackColor = true;
			this.button_Güncelle.Click += new System.EventHandler(this.button_Güncelle_Click);
			// 
			// button_aktifKres
			// 
			this.button_aktifKres.Location = new System.Drawing.Point(701, 354);
			this.button_aktifKres.Name = "button_aktifKres";
			this.button_aktifKres.Size = new System.Drawing.Size(297, 83);
			this.button_aktifKres.TabIndex = 3;
			this.button_aktifKres.Text = "Aktif Kreş";
			this.button_aktifKres.UseVisualStyleBackColor = true;
			this.button_aktifKres.Click += new System.EventHandler(this.button_aktifKres_Click);
			// 
			// YetkiliKres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1010, 488);
			this.Controls.Add(this.button_aktifKres);
			this.Controls.Add(this.button_Güncelle);
			this.Controls.Add(this.buttonKresEkle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "YetkiliKres";
			this.Text = "YetkiliKres";
			this.Load += new System.EventHandler(this.YetkiliKres_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonKresEkle;
		private System.Windows.Forms.Button button_Güncelle;
		private System.Windows.Forms.Button button_aktifKres;
	}
}