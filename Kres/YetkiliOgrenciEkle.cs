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
	public partial class YetkiliOgrenciEkle : Form
	{
		public YetkiliOgrenciEkle()
		{
			InitializeComponent();
		}
		void OgrKaydet()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				if (con.State == System.Data.ConnectionState.Open)
				{
					if (string.IsNullOrWhiteSpace(txt_id.Text) ||
						string.IsNullOrWhiteSpace(txt_ad.Text) ||
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

					SqlCommand cmd = new SqlCommand("INSERT INTO OGRENCI_BİLGİ (Ogrenci_Id, Ogrenci_Ad, Ogrenci_Soyad,Ogrenci_Yas, Ogrenci_Cinsiyet, Ogrenci_Sınıf_Id, Veli_Adı, Veli_Iletisim, Orenci_Adres , Kres_Id,Aktif) VALUES (@Id,@Ad,@Soyad,@Yas,@Cinsiyet,@SınıfId,@VeliAd,@Iletisim,@Adres, @KresId,@Aktif)", con);

					cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_id.Text));
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Soyad", txt_soyad.Text);
					cmd.Parameters.AddWithValue("@Yas", txt_yas.Text);
					cmd.Parameters.AddWithValue("@Cinsiyet", txt_cinsiyet.Text);
					cmd.Parameters.AddWithValue("@SınıfId", Convert.ToInt32(txt_sınıfId.Text));
					cmd.Parameters.AddWithValue("@VeliAd", txt_veliAd.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@KresId", Convert.ToInt32(txt_kresId.Text));
					cmd.Parameters.AddWithValue("@Aktif", Convert.ToInt32(comboBox_aktif.Text));
					txt_id.Clear();
					txt_ad.Clear();
					txt_soyad.Clear();
					txt_yas.Clear();
					txt_cinsiyet.Clear();
					txt_sınıfId.Clear();
					txt_veliAd.Clear();
					txt_iletisim.Clear();
					richTxt_adres.Clear();
					

					int rowsAffected = cmd.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						MessageBox.Show("Kaydetme İşilemi Tamamlandı");
					}
					else
					{
						MessageBox.Show("Kaydetme İşleminde Bir Sorun Oluştu");
					}

				}

				else
				{
					MessageBox.Show("Veritabanına Bağlantı Başarısız.");
				}
			}
		}

		private void buttonEkle_Click(object sender, EventArgs e)
		{
			OgrKaydet();
		}
	}
}
