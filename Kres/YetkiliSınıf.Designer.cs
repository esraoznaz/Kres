namespace Kres
{
	partial class YetkiliSınıf
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
			this.button_AktifSınıf = new System.Windows.Forms.Button();
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
			this.dataGridView1.Size = new System.Drawing.Size(956, 279);
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 327);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(266, 78);
			this.button1.TabIndex = 1;
			this.button1.Text = "Sınıf Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(358, 327);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(266, 78);
			this.button2.TabIndex = 2;
			this.button2.Text = "Sınıfı Güncelle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button_AktifSınıf
			// 
			this.button_AktifSınıf.Location = new System.Drawing.Point(685, 327);
			this.button_AktifSınıf.Name = "button_AktifSınıf";
			this.button_AktifSınıf.Size = new System.Drawing.Size(266, 78);
			this.button_AktifSınıf.TabIndex = 3;
			this.button_AktifSınıf.Text = "Aktif Sınıfı ";
			this.button_AktifSınıf.UseVisualStyleBackColor = true;
			this.button_AktifSınıf.Click += new System.EventHandler(this.button_AktifSınıf_Click);
			// 
			// YetkiliSınıf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 450);
			this.Controls.Add(this.button_AktifSınıf);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "YetkiliSınıf";
			this.Text = "  ";
			this.Load += new System.EventHandler(this.YetkiliSınıf_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button_AktifSınıf;
	}
}