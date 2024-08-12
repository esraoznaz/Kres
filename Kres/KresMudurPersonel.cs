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
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database; 

namespace Kres
{
	public partial class KresMudurPersonel : Form
	{
		public Form1 _form1= new Form1();

		public KresMudurPersonel(Form1 form1)
		{
			InitializeComponent();
			_form1 = form1;
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

					int YetkiId = _form1.Yetki_Id;
					SqlCommand cmd = new SqlCommand("SELECT * FROM PERSONEL WHERE Kres_Id = (SELECT Kres_Id FROM YETKI  WHERE Yetki_Id =@YetkiId )", connection);
					adapter = new SqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
					ds = new DataSet();
					adapter.Fill(ds, "PERSONEL");
					dataGridView1.DataSource = ds.Tables["PERSONEL"];
					

				}
			}

		}
		private void KresMudurPersonel_Load(object sender, EventArgs e)
		{
			 PersonelListele();
		}

		private void button_ekle_Click(object sender, EventArgs e)
		{
			int KresId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
			PERSONEL SeciliKutu = new PERSONEL
			{
				Kres_Id = KresId
			};

			KresMuduruPersonelEkle personelEkle=new KresMuduruPersonelEkle(SeciliKutu);
			personelEkle.Show();
		}
		

		private void button_guncelleme_Click(object sender, EventArgs e)
		{
			int Id= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			string ad= dataGridView1.CurrentRow.Cells[1].Value.ToString();
			string soyad= dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
				Personel_Iletisim=iletisim,
				Personel_eMail=eMail,
				Personel_Adres=adres,
				Personel_Yetki=yetki,
				Kres_Id=KresId
			};
			KresMudurPersonelGuncelle Guncel = new KresMudurPersonelGuncelle(SeciliKutu);

			Guncel.Show();
		}
		void AktifPersoenlListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{

					int YetkiId = _form1.Yetki_Id;
					string sorgu = "SELECT * FROM PERSONEL WHERE Kres_Id = (SELECT Kres_Id FROM YETKI  WHERE Yetki_Id =@YetkiId)AND Aktif = 1 ";
					SqlCommand cmd = new SqlCommand(sorgu, connection);
					adapter = new SqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
					ds = new DataSet();
					adapter.Fill(ds, "PERSONEL");
					dataGridView1.DataSource = ds.Tables["PERSONEL"];


				}
			}
		}
		private void button_aktifPersonel_Click(object sender, EventArgs e)
		{
			AktifPersoenlListele();
		}
	}
}