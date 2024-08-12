using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kres
{
	public partial class YetkiliAnasayfa : Form
	{
		public YetkiliAnasayfa()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void personelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YetkiliPersonel yetkiliPersonel = new YetkiliPersonel();
			yetkiliPersonel.MdiParent = this;
			yetkiliPersonel.Show();
		}

		private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YetkiliOgrenci YetkiliOgr = new YetkiliOgrenci();
			YetkiliOgr.MdiParent = this;
			YetkiliOgr.Show();

		}

		private void sınıfToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YetkiliSınıf yetkiliSınıf =new YetkiliSınıf();
			yetkiliSınıf.MdiParent=this;
			yetkiliSınıf.Show();
		}

		private void kreşToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YetkiliKres kres = new YetkiliKres();
			kres.MdiParent = this;
			kres.Show();
		}

		private void yetkililerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YetkiliYetkililer yetkili=new YetkiliYetkililer();
			yetkili.MdiParent=this;
			yetkili.Show();
		}

		private void YetkiliAnasayfa_Load(object sender, EventArgs e)
		{

		}
	}
}
