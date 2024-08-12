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
	public partial class YetkiliKres : Form
	{
		public YetkiliKres()
		{
			InitializeComponent();
		}
		SqlDataAdapter adapter;
		DataSet ds;
		void KresListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using(SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if(connection.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM KRESLER ", connection);
					ds=new DataSet();
					adapter.Fill(ds, "KRESLER");
					dataGridView1.DataSource = ds.Tables["KRESLER"];
				}
			}
		}
		private void YetkiliKres_Load(object sender, EventArgs e)
		{
			KresListele();
		}

		private void buttonKresEkle_Click(object sender, EventArgs e)
		{
			YetkiliKresEkle KresEkle = new YetkiliKresEkle();
			KresEkle.Show();
		}

		private void button_Güncelle_Click(object sender, EventArgs e)
		{
			int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string adres = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			int kontenjan = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
			string iletisim = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			

			KRESLER SeciliKutu = new KRESLER
			{
				Kres_Id = Id,
				Kres_Ad = ad,
				Kres_Adres = adres,
				Kres_Kontenjan = kontenjan,
				Kres_İletisim = iletisim
				
			};
			YetkiliKresGuncelle KresGuncel = new YetkiliKresGuncelle(SeciliKutu);

			KresGuncel.Show();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		void AktifKresListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM KRESLER WHERE Aktif=1", connection);
					ds = new DataSet();
					adapter.Fill(ds, "KRESLER");
					dataGridView1.DataSource = ds.Tables["KRESLER"];
				}
			}
		}
		private void button_aktifKres_Click(object sender, EventArgs e)
		{
			AktifKresListele();	
		}
	}
}
