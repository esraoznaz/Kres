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
	public partial class KresMudurOgrenciGüncelle : Form
	{
		private OGRENCI_BİLGİ OgrenciBilgi;
		public KresMudurOgrenciGüncelle(OGRENCI_BİLGİ OgrenciBilgi)
		{
			InitializeComponent();
			this.OgrenciBilgi = OgrenciBilgi;
		}
		void Guncelle()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
				{
					if (string.IsNullOrWhiteSpace(txt_ad.Text) ||
						string.IsNullOrWhiteSpace(txt_soyad.Text) ||
						string.IsNullOrWhiteSpace(txt_yas.Text) ||
						string.IsNullOrWhiteSpace(txt_cinsiyet.Text) ||
						string.IsNullOrWhiteSpace(txt_sınıfId.Text) ||
						string.IsNullOrWhiteSpace(txt_veliAd.Text) ||
						string.IsNullOrWhiteSpace(txt_iletisim.Text) ||
						string.IsNullOrWhiteSpace(richTxt_adres.Text) ||
						string.IsNullOrWhiteSpace(comboBox_aktif.Text))
					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return;
					}
					string guncelle = "UPDATE OGRENCI_BİLGİ SET  Ogrenci_Ad=@Ad, Ogrenci_Soyad=@Soyad, Ogrenci_Yas=@Yas, Ogrenci_Cinsiyet=@Cinsiyet, Ogrenci_Sınıf_Id=@SınıfId, Veli_Adı=@VeliAd, Veli_Iletisim=@Iletisim, Orenci_Adres=@Adres, Kres_Id=@KresId, Aktif=@Aktif WHERE Ogrenci_Id=@Id";
					SqlCommand cmd = new SqlCommand(guncelle, connection);
					cmd.Parameters.AddWithValue("@Id", int.Parse(label_id.Text));
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Soyad", txt_soyad.Text);
					cmd.Parameters.AddWithValue("@Yas", txt_yas.Text);
					cmd.Parameters.AddWithValue("@Cinsiyet", txt_cinsiyet.Text);
					cmd.Parameters.AddWithValue("@SınıfId", txt_sınıfId.Text);
					cmd.Parameters.AddWithValue("@VeliAd", txt_veliAd.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@KresId", int.Parse(label_kres.Text));
					cmd.Parameters.AddWithValue("@Aktif", comboBox_aktif.Text);
					int rowsAffected = cmd.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						MessageBox.Show("Güncelleme İşilemi Tamamlandı.");
					}
					else
					{
						MessageBox.Show("ID Değerine Güncelleme İşlemi Yapılmaz. ");
					}
					connection.Close();
				}
			}
		}
		private void buttonGuncelle_Click(object sender, EventArgs e)
		{
			Guncelle();
		}

		private void KresMudurOgrenciGüncelle_Load(object sender, EventArgs e)
		{
			label_id.Text = OgrenciBilgi.Ogrenci_Id.ToString();
			txt_ad.Text = OgrenciBilgi.Ogrenci_Ad;
			txt_soyad.Text = OgrenciBilgi.Ogrenci_Soyad;
			txt_yas.Text = OgrenciBilgi.Ogrenci_Yas;
			txt_cinsiyet.Text = OgrenciBilgi.Ogrenci_Cinsiyet;
			txt_sınıfId.Text = OgrenciBilgi.Ogrenci_Sınıf_Id.ToString();
			txt_veliAd.Text = OgrenciBilgi.Veli_Adı;
			txt_iletisim.Text = OgrenciBilgi.Veli_Iletisim;
			richTxt_adres.Text = OgrenciBilgi.Orenci_Adres;
			label_kres.Text=OgrenciBilgi.Kres_Id.ToString();
		}

		private void label_kres_Click(object sender, EventArgs e)
		{

		}
	}
}
