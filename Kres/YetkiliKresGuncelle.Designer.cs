﻿namespace Kres
{
	partial class YetkiliKresGuncelle
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
			this.button_Guncelle = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_iletisim = new System.Windows.Forms.TextBox();
			this.txt_kontenjan = new System.Windows.Forms.TextBox();
			this.txt_ad = new System.Windows.Forms.TextBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_aktif = new System.Windows.Forms.ComboBox();
			this.richTxt_adres = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Guncelle
			// 
			this.button_Guncelle.Location = new System.Drawing.Point(173, 359);
			this.button_Guncelle.Name = "button_Guncelle";
			this.button_Guncelle.Size = new System.Drawing.Size(195, 61);
			this.button_Guncelle.TabIndex = 3;
			this.button_Guncelle.Text = "GÜNCELLE";
			this.button_Guncelle.UseVisualStyleBackColor = true;
			this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTxt_adres);
			this.groupBox1.Controls.Add(this.comboBox_aktif);
			this.groupBox1.Controls.Add(this.txt_iletisim);
			this.groupBox1.Controls.Add(this.txt_kontenjan);
			this.groupBox1.Controls.Add(this.txt_ad);
			this.groupBox1.Controls.Add(this.txt_id);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(144, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 312);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kreş Güncelle";
			// 
			// txt_iletisim
			// 
			this.txt_iletisim.Location = new System.Drawing.Point(103, 220);
			this.txt_iletisim.Name = "txt_iletisim";
			this.txt_iletisim.Size = new System.Drawing.Size(121, 22);
			this.txt_iletisim.TabIndex = 10;
			// 
			// txt_kontenjan
			// 
			this.txt_kontenjan.Location = new System.Drawing.Point(103, 192);
			this.txt_kontenjan.Name = "txt_kontenjan";
			this.txt_kontenjan.Size = new System.Drawing.Size(121, 22);
			this.txt_kontenjan.TabIndex = 9;
			// 
			// txt_ad
			// 
			this.txt_ad.Location = new System.Drawing.Point(103, 61);
			this.txt_ad.Name = "txt_ad";
			this.txt_ad.Size = new System.Drawing.Size(121, 22);
			this.txt_ad.TabIndex = 7;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(103, 33);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(121, 22);
			this.txt_id.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Aktif:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Iletişim:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kontenjan:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Adres:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kreş Ad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kereş Id:";
			// 
			// comboBox_aktif
			// 
			this.comboBox_aktif.FormattingEnabled = true;
			this.comboBox_aktif.Items.AddRange(new object[] {
            "1",
            "0"});
			this.comboBox_aktif.Location = new System.Drawing.Point(103, 248);
			this.comboBox_aktif.Name = "comboBox_aktif";
			this.comboBox_aktif.Size = new System.Drawing.Size(121, 24);
			this.comboBox_aktif.TabIndex = 11;
			// 
			// richTxt_adres
			// 
			this.richTxt_adres.Location = new System.Drawing.Point(103, 90);
			this.richTxt_adres.Name = "richTxt_adres";
			this.richTxt_adres.Size = new System.Drawing.Size(121, 96);
			this.richTxt_adres.TabIndex = 12;
			this.richTxt_adres.Text = "";
			// 
			// YetkiliKresGuncelle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 450);
			this.Controls.Add(this.button_Guncelle);
			this.Controls.Add(this.groupBox1);
			this.Name = "YetkiliKresGuncelle";
			this.Text = "YetkiliKresGuncelle";
			this.Load += new System.EventHandler(this.YetkiliKresGuncelle_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Guncelle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_iletisim;
		private System.Windows.Forms.TextBox txt_kontenjan;
		private System.Windows.Forms.TextBox txt_ad;
		private System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTxt_adres;
		private System.Windows.Forms.ComboBox comboBox_aktif;
	}
}