namespace Kres
{
	partial class KresMudurAnasayfa
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öğencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sınıflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.öğencilerToolStripMenuItem,
            this.sınıflarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1580, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// personelToolStripMenuItem
			// 
			this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
			this.personelToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
			this.personelToolStripMenuItem.Text = "Personel";
			this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
			// 
			// öğencilerToolStripMenuItem
			// 
			this.öğencilerToolStripMenuItem.Name = "öğencilerToolStripMenuItem";
			this.öğencilerToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
			this.öğencilerToolStripMenuItem.Text = "Öğenciler";
			this.öğencilerToolStripMenuItem.Click += new System.EventHandler(this.öğencilerToolStripMenuItem_Click);
			// 
			// sınıflarToolStripMenuItem
			// 
			this.sınıflarToolStripMenuItem.Name = "sınıflarToolStripMenuItem";
			this.sınıflarToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			this.sınıflarToolStripMenuItem.Text = "Sınıflar";
			this.sınıflarToolStripMenuItem.Click += new System.EventHandler(this.sınıflarToolStripMenuItem_Click);
			// 
			// KresMudurAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1580, 615);
			this.Controls.Add(this.menuStrip1);
			this.Name = "KresMudurAnasayfa";
			this.Text = "KresMudurAnasayfa";
			this.Load += new System.EventHandler(this.KresMudurAnasayfa_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öğencilerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sınıflarToolStripMenuItem;
	}
}