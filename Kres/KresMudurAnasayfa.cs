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
	public partial class KresMudurAnasayfa : Form
	{
		private Form1 _form1;

		public KresMudurAnasayfa(Form1 form1)
		{
			InitializeComponent();
			_form1 = form1;
			this.IsMdiContainer = true;
		}

		//public KresMudurAnasayfa()
		//{
		//	InitializeComponent();
		//	this.IsMdiContainer = true;
		//}


		private void personelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KresMudurPersonel kresMudurPersonelForm = new KresMudurPersonel(_form1);
			kresMudurPersonelForm.MdiParent = this;
			kresMudurPersonelForm.Show();
		}

		private void öğencilerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Kres_Mudur_Ogrenci kres_mudur_ogrenci=new Kres_Mudur_Ogrenci(_form1);
			kres_mudur_ogrenci.MdiParent = this;
			kres_mudur_ogrenci.Show();
		}

		private void sınıflarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KresMudurSınıfcs sınıf=new KresMudurSınıfcs(_form1);
			sınıf.MdiParent=this;
			sınıf.Show();
		}

		private void KresMudurAnasayfa_Load(object sender, EventArgs e)
		{
			
		}

		private void lblWelcome_Click(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			
		}
	}
}
