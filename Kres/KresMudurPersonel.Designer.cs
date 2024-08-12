namespace Kres
{
	partial class KresMudurPersonel
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
			this.button_guncelleme = new System.Windows.Forms.Button();
			this.button_aktifPersonel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1286, 311);
			this.dataGridView1.TabIndex = 0;
			// 
			// button_ekle
			// 
			this.button_ekle.Location = new System.Drawing.Point(157, 361);
			this.button_ekle.Name = "button_ekle";
			this.button_ekle.Size = new System.Drawing.Size(280, 74);
			this.button_ekle.TabIndex = 1;
			this.button_ekle.Text = "Personel Ekle";
			this.button_ekle.UseVisualStyleBackColor = true;
			this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
			// 
			// button_guncelleme
			// 
			this.button_guncelleme.Location = new System.Drawing.Point(494, 361);
			this.button_guncelleme.Name = "button_guncelleme";
			this.button_guncelleme.Size = new System.Drawing.Size(280, 74);
			this.button_guncelleme.TabIndex = 2;
			this.button_guncelleme.Text = "Bilgileri Güncelle";
			this.button_guncelleme.UseVisualStyleBackColor = true;
			this.button_guncelleme.Click += new System.EventHandler(this.button_guncelleme_Click);
			// 
			// button_aktifPersonel
			// 
			this.button_aktifPersonel.Location = new System.Drawing.Point(824, 361);
			this.button_aktifPersonel.Name = "button_aktifPersonel";
			this.button_aktifPersonel.Size = new System.Drawing.Size(280, 74);
			this.button_aktifPersonel.TabIndex = 3;
			this.button_aktifPersonel.Text = "Aktif Personeller";
			this.button_aktifPersonel.UseVisualStyleBackColor = true;
			this.button_aktifPersonel.Click += new System.EventHandler(this.button_aktifPersonel_Click);
			// 
			// KresMudurPersonel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1310, 459);
			this.Controls.Add(this.button_aktifPersonel);
			this.Controls.Add(this.button_guncelleme);
			this.Controls.Add(this.button_ekle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "KresMudurPersonel";
			this.Text = "KresMudurPersonel";
			this.Load += new System.EventHandler(this.KresMudurPersonel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_ekle;
		private System.Windows.Forms.Button button_guncelleme;
		private System.Windows.Forms.Button button_aktifPersonel;
	}
}