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
	public partial class YetkiliPersonel : Form
	{
		public YetkiliPersonel()
		{
			InitializeComponent();
		}
		SqlDataAdapter adapter;
		DataSet ds;
		void PersonelListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					DataTable dataTable = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM PERSONEL ", connection);
					ds = new DataSet();
					adapter.Fill(ds, "PERSONEL");
					dataGridView1.DataSource = ds.Tables["PERSONEL"];

				}
			}

		}

		private void YetkiliPersonel_Load(object sender, EventArgs e)
		{
			PersonelListele();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			YetkiliPersoenelEkle yetkiliPersoenelEkle=new YetkiliPersoenelEkle();
			yetkiliPersoenelEkle.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			string iletisim = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			string eMail = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			string adres = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			string yetki = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			int KresId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);

			PERSONEL SeciliKutu = new PERSONEL
			{
				Personel_Id = Id,
				Personel_Ad = ad,
				Personel_Soyad = soyad,
				Personel_Iletisim = iletisim,
				Personel_eMail = eMail,
				Personel_Adres = adres,
				Personel_Yetki = yetki,
				Kres_Id = KresId
			};
			YetkiliPersonelGuncel Guncel = new YetkiliPersonelGuncel(SeciliKutu);

			Guncel.Show();  
		}

		void AktifPersonelListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					DataTable dataTable = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM PERSONEL WHERE Aktif=1", connection);
					ds = new DataSet();
					adapter.Fill(ds, "PERSONEL");
					dataGridView1.DataSource = ds.Tables["PERSONEL"];

				}
			}

		}

		private void button_AktifPersonel_Click(object sender, EventArgs e)
		{
			AktifPersonelListele();
		}
	} 
}