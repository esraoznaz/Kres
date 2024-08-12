namespace Kres
{
	partial class YetkiliAnasayfa
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
			this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sınıfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kreşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yetkililerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// personelToolStripMenuItem
			// 
			this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
			this.personelToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
			this.personelToolStripMenuItem.Text = "Personel";
			this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
			// 
			// öğrenciToolStripMenuItem
			// 
			this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
			this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.öğrenciToolStripMenuItem.Text = "Öğrenci";
			this.öğrenciToolStripMenuItem.Click += new System.EventHandler(this.öğrenciToolStripMenuItem_Click);
			// 
			// sınıfToolStripMenuItem
			// 
			this.sınıfToolStripMenuItem.Name = "sınıfToolStripMenuItem";
			this.sınıfToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.sınıfToolStripMenuItem.Text = "Sınıf";
			this.sınıfToolStripMenuItem.Click += new System.EventHandler(this.sınıfToolStripMenuItem_Click);
			// 
			// kreşToolStripMenuItem
			// 
			this.kreşToolStripMenuItem.Name = "kreşToolStripMenuItem";
			this.kreşToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.kreşToolStripMenuItem.Text = "Kreş";
			this.kreşToolStripMenuItem.Click += new System.EventHandler(this.kreşToolStripMenuItem_Click);
			// 
			// yetkililerToolStripMenuItem
			// 
			this.yetkililerToolStripMenuItem.Name = "yetkililerToolStripMenuItem";
			this.yetkililerToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.yetkililerToolStripMenuItem.Text = "Yetkililer";
			this.yetkililerToolStripMenuItem.Click += new System.EventHandler(this.yetkililerToolStripMenuItem_Click);
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.sınıfToolStripMenuItem,
            this.kreşToolStripMenuItem,
            this.yetkililerToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(1781, 28);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// YetkiliAnasayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1781, 679);
			this.Controls.Add(this.menuStrip2);
			this.Name = "YetkiliAnasayfa";
			this.Text = "YetkiliAnasayfa";
			this.Load += new System.EventHandler(this.YetkiliAnasayfa_Load);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sınıfToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kreşToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yetkililerToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip2;
	}
}