namespace Kres
{
	partial class YetkiliSınıfGuncelle
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
			this.buttonGuncelle = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox_aktif = new System.Windows.Forms.ComboBox();
			this.txt_kresID = new System.Windows.Forms.TextBox();
			this.txt_personelId = new System.Windows.Forms.TextBox();
			this.txt_sınıfKontenjan = new System.Windows.Forms.TextBox();
			this.txt_sınıfAd = new System.Windows.Forms.TextBox();
			this.txt_sınıfId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonGuncelle
			// 
			this.buttonGuncelle.Location = new System.Drawing.Point(270, 338);
			this.buttonGuncelle.Name = "buttonGuncelle";
			this.buttonGuncelle.Size = new System.Drawing.Size(240, 66);
			this.buttonGuncelle.TabIndex = 3;
			this.buttonGuncelle.Text = "GÜNCELLE";
			this.buttonGuncelle.UseVisualStyleBackColor = true;
			this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox_aktif);
			this.groupBox1.Controls.Add(this.txt_kresID);
			this.groupBox1.Controls.Add(this.txt_personelId);
			this.groupBox1.Controls.Add(this.txt_sınıfKontenjan);
			this.groupBox1.Controls.Add(this.txt_sınıfAd);
			this.groupBox1.Controls.Add(this.txt_sınıfId);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(180, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(440, 274);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sınıf Güncelle";
			// 
			// comboBox_aktif
			// 
			this.comboBox_aktif.FormattingEnabled = true;
			this.comboBox_aktif.Items.AddRange(new object[] {
            "0",
            "1"});
			this.comboBox_aktif.Location = new System.Drawing.Point(209, 208);
			this.comboBox_aktif.Name = "comboBox_aktif";
			this.comboBox_aktif.Size = new System.Drawing.Size(121, 24);
			this.comboBox_aktif.TabIndex = 11;
			// 
			// txt_kresID
			// 
			this.txt_kresID.Location = new System.Drawing.Point(209, 179);
			this.txt_kresID.Name = "txt_kresID";
			this.txt_kresID.Size = new System.Drawing.Size(121, 22);
			this.txt_kresID.TabIndex = 10;
			// 
			// txt_personelId
			// 
			this.txt_personelId.Location = new System.Drawing.Point(209, 151);
			this.txt_personelId.Name = "txt_personelId";
			this.txt_personelId.Size = new System.Drawing.Size(121, 22);
			this.txt_personelId.TabIndex = 9;
			// 
			// txt_sınıfKontenjan
			// 
			this.txt_sınıfKontenjan.Location = new System.Drawing.Point(209, 123);
			this.txt_sınıfKontenjan.Name = "txt_sınıfKontenjan";
			this.txt_sınıfKontenjan.Size = new System.Drawing.Size(121, 22);
			this.txt_sınıfKontenjan.TabIndex = 8;
			// 
			// txt_sınıfAd
			// 
			this.txt_sınıfAd.Location = new System.Drawing.Point(209, 95);
			this.txt_sınıfAd.Name = "txt_sınıfAd";
			this.txt_sınıfAd.Size = new System.Drawing.Size(121, 22);
			this.txt_sınıfAd.TabIndex = 7;
			// 
			// txt_sınıfId
			// 
			this.txt_sınıfId.Location = new System.Drawing.Point(209, 67);
			this.txt_sınıfId.Name = "txt_sınıfId";
			this.txt_sınıfId.Size = new System.Drawing.Size(121, 22);
			this.txt_sınıfId.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(87, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Aktif:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(87, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Kres Id:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(87, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Personel Id:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sınıf Kontenjan:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(87, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sınıf Ad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sınıf Id:";
			// 
			// YetkiliSınıfGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonGuncelle);
			this.Controls.Add(this.groupBox1);
			this.Name = "YetkiliSınıfGuncelle";
			this.Text = "YetkiliSınıfGuncelle";
			this.Load += new System.EventHandler(this.YetkiliSınıfGuncelle_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonGuncelle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox_aktif;
		private System.Windows.Forms.TextBox txt_kresID;
		private System.Windows.Forms.TextBox txt_personelId;
		private System.Windows.Forms.TextBox txt_sınıfKontenjan;
		private System.Windows.Forms.TextBox txt_sınıfAd;
		private System.Windows.Forms.TextBox txt_sınıfId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}