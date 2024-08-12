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
	public partial class Kres_Mudur_Ogrenci : Form
	{
		public Form1 _form1 = new Form1();
		public Kres_Mudur_Ogrenci(Form1 form1)
		{
			InitializeComponent();
			_form1 = form1;
		}
		SqlDataAdapter adapter;
		DataSet ds;
		void OgrenciListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					int YetkiId = _form1.Yetki_Id;
					SqlCommand cmd = new SqlCommand("SELECT * FROM OGRENCI_BİLGİ WHERE Kres_Id = (SELECT Kres_Id FROM YETKI  WHERE Yetki_Id =@YetkiId )", connection);
					adapter = new SqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
					DataTable dataTable = new DataTable();
					ds = new DataSet();
					adapter.Fill(ds, "OGRENCI_BİLGİ");
					dataGridView1.DataSource = ds.Tables["OGRENCI_BİLGİ"];

				}
			}

		}
		private void Kres_Mudur_Ogrenci_Load(object sender, EventArgs e)
		{
			OgrenciListele();
		}
		private void button_ekle_Click(object sender, EventArgs e)
		{
			int kresId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
			OGRENCI_BİLGİ SeciliKutu = new OGRENCI_BİLGİ
			{
				Kres_Id = kresId
			};

			KresMudurOgrenciEkle OgrenciEkle = new KresMudurOgrenciEkle(SeciliKutu);
			OgrenciEkle.Show();
		}

		private void button_güncelle_Click(object sender, EventArgs e)
		{
			int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			string ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			string yas = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			string cinsiyet = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			int SınıfId = Convert.ToInt32(Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString()));
			string veliad = dataGridView1.CurrentRow.Cells[6].Value.ToString();
			string veliIletisim = dataGridView1.CurrentRow.Cells[7].Value.ToString();
			string OgrenciAdres = dataGridView1.CurrentRow.Cells[8].Value.ToString();
			int kresId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);


			OGRENCI_BİLGİ SeciliKutu = new OGRENCI_BİLGİ
			{
				Ogrenci_Id = Id,
				Ogrenci_Ad = ad,
				Ogrenci_Soyad = soyad,
				Ogrenci_Yas = yas,
				Ogrenci_Cinsiyet = cinsiyet,
				Ogrenci_Sınıf_Id = SınıfId,
				Veli_Adı = veliad,
				Veli_Iletisim = veliIletisim,
				Orenci_Adres = OgrenciAdres,
				Kres_Id = kresId
			};
			KresMudurOgrenciGüncelle OgrenciGuncel = new KresMudurOgrenciGüncelle(SeciliKutu);

			OgrenciGuncel.Show();
		}
		void AktifOgrenciListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					int YetkiId = _form1.Yetki_Id;
					SqlCommand cmd = new SqlCommand("SELECT * FROM OGRENCI_BİLGİ WHERE Kres_Id = (SELECT Kres_Id FROM YETKI  WHERE Yetki_Id =@YetkiId ) AND Aktif=1", connection);
					adapter = new SqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
					DataTable dataTable = new DataTable();
					ds = new DataSet();
					adapter.Fill(ds, "OGRENCI_BİLGİ");
					dataGridView1.DataSource = ds.Tables["OGRENCI_BİLGİ"];

				}
			}
		}
		private void button_aktifOgrenci_Click(object sender, EventArgs e)
		{
			AktifOgrenciListele();
		}
	}
}