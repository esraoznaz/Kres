namespace Kres
{
	partial class KresMudurOgrenciEkle
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
			this.buttonEkle = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox_aktif = new System.Windows.Forms.ComboBox();
			this.richTxt_adres = new System.Windows.Forms.RichTextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_iletisim = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label_id = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label_kres = new System.Windows.Forms.Label();
			this.txt_veliAd = new System.Windows.Forms.TextBox();
			this.txt_sınıfId = new System.Windows.Forms.TextBox();
			this.txt_ad = new System.Windows.Forms.TextBox();
			this.txt_soyad = new System.Windows.Forms.TextBox();
			this.txt_yas = new System.Windows.Forms.TextBox();
			this.txt_cinsiyet = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonEkle
			// 
			this.buttonEkle.Location = new System.Drawing.Point(337, 477);
			this.buttonEkle.Name = "buttonEkle";
			this.buttonEkle.Size = new System.Drawing.Size(150, 49);
			this.buttonEkle.TabIndex = 17;
			this.buttonEkle.Text = "KAYDET";
			this.buttonEkle.UseVisualStyleBackColor = true;
			this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox_aktif);
			this.groupBox1.Controls.Add(this.richTxt_adres);
			this.groupBox1.Controls.Add(this.txt_id);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txt_iletisim);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label_id);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label_kres);
			this.groupBox1.Controls.Add(this.txt_veliAd);
			this.groupBox1.Controls.Add(this.txt_sınıfId);
			this.groupBox1.Controls.Add(this.txt_ad);
			this.groupBox1.Controls.Add(this.txt_soyad);
			this.groupBox1.Controls.Add(this.txt_yas);
			this.groupBox1.Controls.Add(this.txt_cinsiyet);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(207, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(389, 459);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Öğrenci Ekle";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// comboBox_aktif
			// 
			this.comboBox_aktif.FormattingEnabled = true;
			this.comboBox_aktif.Items.AddRange(new object[] {
            "1",
            "0"});
			this.comboBox_aktif.Location = new System.Drawing.Point(200, 359);
			this.comboBox_aktif.Name = "comboBox_aktif";
			this.comboBox_aktif.Size = new System.Drawing.Size(121, 24);
			this.comboBox_aktif.TabIndex = 34;
			// 
			// richTxt_adres
			// 
			this.richTxt_adres.Location = new System.Drawing.Point(200, 256);
			this.richTxt_adres.Name = "richTxt_adres";
			this.richTxt_adres.Size = new System.Drawing.Size(121, 96);
			this.richTxt_adres.TabIndex = 33;
			this.richTxt_adres.Text = "";
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(200, 32);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(121, 22);
			this.txt_id.TabIndex = 32;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(76, 359);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(35, 16);
			this.label13.TabIndex = 30;
			this.label13.Text = "Aktif:";
			// 
			// txt_iletisim
			// 
			this.txt_iletisim.Location = new System.Drawing.Point(200, 228);
			this.txt_iletisim.Name = "txt_iletisim";
			this.txt_iletisim.Size = new System.Drawing.Size(121, 22);
			this.txt_iletisim.TabIndex = 26;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(76, 256);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 16);
			this.label11.TabIndex = 22;
			this.label11.Text = "Öğrenci Adres:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(76, 389);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(51, 16);
			this.label15.TabIndex = 25;
			this.label15.Text = "Kreş Id:";
			// 
			// label_id
			// 
			this.label_id.AutoSize = true;
			this.label_id.Location = new System.Drawing.Point(197, 32);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(0, 16);
			this.label_id.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(76, 32);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 16);
			this.label12.TabIndex = 20;
			this.label12.Text = "Öğrenci Id:";
			// 
			// label_kres
			// 
			this.label_kres.AutoSize = true;
			this.label_kres.Location = new System.Drawing.Point(197, 389);
			this.label_kres.Name = "label_kres";
			this.label_kres.Size = new System.Drawing.Size(14, 16);
			this.label_kres.TabIndex = 19;
			this.label_kres.Text = "1";
			// 
			// txt_veliAd
			// 
			this.txt_veliAd.Location = new System.Drawing.Point(200, 200);
			this.txt_veliAd.Name = "txt_veliAd";
			this.txt_veliAd.Size = new System.Drawing.Size(121, 22);
			this.txt_veliAd.TabIndex = 17;
			// 
			// txt_sınıfId
			// 
			this.txt_sınıfId.Location = new System.Drawing.Point(200, 172);
			this.txt_sınıfId.Name = "txt_sınıfId";
			this.txt_sınıfId.Size = new System.Drawing.Size(121, 22);
			this.txt_sınıfId.TabIndex = 15;
			// 
			// txt_ad
			// 
			this.txt_ad.Location = new System.Drawing.Point(200, 60);
			this.txt_ad.Name = "txt_ad";
			this.txt_ad.Size = new System.Drawing.Size(121, 22);
			this.txt_ad.TabIndex = 14;
			// 
			// txt_soyad
			// 
			this.txt_soyad.Location = new System.Drawing.Point(200, 88);
			this.txt_soyad.Name = "txt_soyad";
			this.txt_soyad.Size = new System.Drawing.Size(121, 22);
			this.txt_soyad.TabIndex = 13;
			// 
			// txt_yas
			// 
			this.txt_yas.Location = new System.Drawing.Point(200, 116);
			this.txt_yas.Name = "txt_yas";
			this.txt_yas.Size = new System.Drawing.Size(121, 22);
			this.txt_yas.TabIndex = 12;
			// 
			// txt_cinsiyet
			// 
			this.txt_cinsiyet.Location = new System.Drawing.Point(200, 144);
			this.txt_cinsiyet.Name = "txt_cinsiyet";
			this.txt_cinsiyet.Size = new System.Drawing.Size(121, 22);
			this.txt_cinsiyet.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Öğrenci Ad:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(76, 200);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 9;
			this.label10.Text = "Veli Adı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(76, 228);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 8;
			this.label9.Text = "Veli İletiişim:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(76, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Personel Soyad:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(76, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Öğrenci Yaş:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(76, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Öğrenci Sınıf Id:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(76, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Öğrenci Cinsiyet:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(374, 181);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 16);
			this.label3.TabIndex = 15;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// KresMudurOgrenciEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 538);
			this.Controls.Add(this.buttonEkle);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Name = "KresMudurOgrenciEkle";
			this.Text = "KresMudurOgrenciEkle";
			this.Load += new System.EventHandler(this.KresMudurOgrenciEkle_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonEkle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txt_iletisim;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label_id;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label_kres;
		private System.Windows.Forms.TextBox txt_veliAd;
		private System.Windows.Forms.TextBox txt_sınıfId;
		private System.Windows.Forms.TextBox txt_ad;
		private System.Windows.Forms.TextBox txt_soyad;
		private System.Windows.Forms.TextBox txt_yas;
		private System.Windows.Forms.TextBox txt_cinsiyet;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.ComboBox comboBox_aktif;
		private System.Windows.Forms.RichTextBox richTxt_adres;
	}
}