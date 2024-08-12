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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Kres
{
	public partial class YetkiliYetkililer : Form
	{
		public YetkiliYetkililer()
		{
			InitializeComponent();
		}
		SqlDataAdapter adapter;
		DataSet ds;
		void YetkiliListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				if (conn.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM YETKI", conn);
					ds= new DataSet();
					adapter.Fill(ds, "YETKI");
					dataGridView1.DataSource = ds.Tables["YETKI"];
				}
			}
		}
		private void YetkiliYetkililer_Load(object sender, EventArgs e)
		{
			YetkiliListele();	
		}

		private void button_kaydet_Click(object sender, EventArgs e)
		{
			YetkiYetkililerEkle yetkililerEkle= new YetkiYetkililerEkle();
			yetkililerEkle.Show();
		}

		private void button_guncelle_Click(object sender, EventArgs e)
		{

			int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			string turu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string ad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			string iletisim = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			string adres = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			string email = dataGridView1.CurrentRow.Cells[5].Value.ToString();
			string sifre = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			int kresId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
			//string aktif = dataGridView1.CurrentRow.Cells[7].Value.ToString();


			YETKI SeciliKutu = new YETKI
			{
				Yetki_Id = Id,
				Yetki_turu = turu,
				Yetkili_ad = ad,
				Yetkili_Iletisim = iletisim,
				Yetkili_Adres = adres,
				Yetkili_eMail = email,
				Yetkili_Sifre = sifre,
				Kres_Id=kresId,
				//Aktif = aktif
				
			};
			YetkiYetkililerGuncellecs YetkiliGuncel = new YetkiYetkililerGuncellecs(SeciliKutu);

			YetkiliGuncel.Show();
		}
		void AktifYetkiliListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				if (conn.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					adapter = new SqlDataAdapter("SELECT * FROM YETKI WHERE Aktif=1", conn);
					ds = new DataSet();
					adapter.Fill(ds, "YETKI");
					dataGridView1.DataSource = ds.Tables["YETKI"];
				}
			}
		}

		private void button_aktifYetkili_Click(object sender, EventArgs e)
		{
			AktifYetkiliListele();
		}
	}
}
