namespace Kres
{
	partial class YetkiliPersonel
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button_AktifPersonel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1283, 285);
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(239, 334);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(262, 87);
			this.button1.TabIndex = 1;
			this.button1.Text = "Personel Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(562, 334);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(262, 87);
			this.button2.TabIndex = 2;
			this.button2.Text = "Güncelle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button_AktifPersonel
			// 
			this.button_AktifPersonel.Location = new System.Drawing.Point(881, 334);
			this.button_AktifPersonel.Name = "button_AktifPersonel";
			this.button_AktifPersonel.Size = new System.Drawing.Size(262, 87);
			this.button_AktifPersonel.TabIndex = 3;
			this.button_AktifPersonel.Text = "Aktif Personel ";
			this.button_AktifPersonel.UseVisualStyleBackColor = true;
			this.button_AktifPersonel.Click += new System.EventHandler(this.button_AktifPersonel_Click);
			// 
			// YetkiliPersonel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1307, 450);
			this.Controls.Add(this.button_AktifPersonel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "YetkiliPersonel";
			this.Text = "YetkiliPersonel";
			this.Load += new System.EventHandler(this.YetkiliPersonel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button_AktifPersonel;
	}
}