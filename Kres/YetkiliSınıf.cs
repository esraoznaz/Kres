using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kres
{
	public partial class YetkiliSınıf : Form
	{
		public YetkiliSınıf()
		{
			InitializeComponent();
		}
		SqlDataAdapter adapter;
		DataSet ds;
		void SınıfListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM SINIF ", connection);
					ds = new DataSet();
					adapter.Fill(ds, "SINIF");
					dataGridView1.DataSource = ds.Tables["SINIF"];
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			YetkliSınıfEkle yetkliSınıfEkle=new YetkliSınıfEkle();
			yetkliSınıfEkle.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int sınıfId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			string sınıfAd = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			int kontenjan = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
			int personelId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
			int kresId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
			
			

			SINIF SeciliKutu = new SINIF
			{
				Sınıf_Id=sınıfId,
				Sınıf_Ad=sınıfAd,
				Sınıf_Kontenjan=kontenjan,
				Personel_Id=personelId,
				Kres_Id=kresId
				
			};
			YetkiliSınıfGuncelle KresGuncel = new YetkiliSınıfGuncelle(SeciliKutu);

			KresGuncel.Show();
		}

		private void YetkiliSınıf_Load(object sender, EventArgs e)
		{
			SınıfListele();
		}
		void AktifSınıfListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM SINIF WHERE Aktif=1 ", connection);
					ds = new DataSet();
					adapter.Fill(ds, "SINIF");
					dataGridView1.DataSource = ds.Tables["SINIF"];
				}
			}
		}

		private void button_AktifSınıf_Click(object sender, EventArgs e)
		{
			AktifSınıfListele();
		}
	}
}
