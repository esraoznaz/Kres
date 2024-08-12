namespace Kres
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.txt_sifre = new System.Windows.Forms.TextBox();
			this.chkKresMuduru = new System.Windows.Forms.CheckBox();
			this.chkYetkili = new System.Windows.Forms.CheckBox();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(279, 265);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 61);
			this.button1.TabIndex = 0;
			this.button1.Text = "GİRİŞ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(162, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı eMail:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(220, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(279, 100);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(181, 22);
			this.txt_email.TabIndex = 3;
			// 
			// txt_sifre
			// 
			this.txt_sifre.Location = new System.Drawing.Point(279, 154);
			this.txt_sifre.Name = "txt_sifre";
			this.txt_sifre.Size = new System.Drawing.Size(181, 22);
			this.txt_sifre.TabIndex = 4;
			// 
			// chkKresMuduru
			// 
			this.chkKresMuduru.AutoSize = true;
			this.chkKresMuduru.Location = new System.Drawing.Point(279, 192);
			this.chkKresMuduru.Name = "chkKresMuduru";
			this.chkKresMuduru.Size = new System.Drawing.Size(103, 20);
			this.chkKresMuduru.TabIndex = 5;
			this.chkKresMuduru.Text = "Kreş Müdürü";
			this.chkKresMuduru.UseVisualStyleBackColor = true;
			// 
			// chkYetkili
			// 
			this.chkYetkili.AutoSize = true;
			this.chkYetkili.Location = new System.Drawing.Point(279, 218);
			this.chkYetkili.Name = "chkYetkili";
			this.chkYetkili.Size = new System.Drawing.Size(77, 20);
			this.chkYetkili.TabIndex = 6;
			this.chkYetkili.Text = "Yönetici";
			this.chkYetkili.UseVisualStyleBackColor = true;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(279, 54);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(181, 22);
			this.txt_id.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(162, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kullanıcı Id:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 407);
			this.Controls.Add(this.txt_id);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.chkYetkili);
			this.Controls.Add(this.chkKresMuduru);
			this.Controls.Add(this.txt_sifre);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Giriş Ekranı";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.TextBox txt_sifre;
		private System.Windows.Forms.CheckBox chkKresMuduru;
		private System.Windows.Forms.CheckBox chkYetkili;
		public System.Windows.Forms.TextBox txt_id;
		private System.Windows.Forms.Label label3;
	}
}

