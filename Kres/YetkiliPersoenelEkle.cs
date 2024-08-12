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
	public partial class YetkiliPersoenelEkle : Form
	{
		public YetkiliPersoenelEkle()
		{
			InitializeComponent();
		}
		void Kaydet()
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
						string.IsNullOrWhiteSpace(txt_iletisim.Text) ||
						string.IsNullOrWhiteSpace(txt_email.Text) ||
						string.IsNullOrWhiteSpace(richTxt_adres.Text) ||
						string.IsNullOrWhiteSpace(comboBox_aktif.Text) ||
						string.IsNullOrWhiteSpace(txt_yetki.Text))
					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return;
					}
					SqlCommand cmd = new SqlCommand("INSERT INTO PERSONEL(Personel_Id,Personel_Ad, Personel_Soyad, Personel_Iletisim, Personel_eMail, Personel_Adres, Personel_Yetki, Kres_Id,Aktif) VALUES (@ID, @Ad, @Soyad, @Iletisim, @eMail, @Adres, @Yetki, @KresId, @Aktif)", con);


					cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_id.Text));
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Soyad", txt_soyad.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@eMail", txt_email.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@Yetki", txt_yetki.Text);
					cmd.Parameters.AddWithValue("@KresId", Convert.ToInt32(txt_kresId.Text));
					cmd.Parameters.AddWithValue("@Aktif", Convert.ToInt32(comboBox_aktif.Text));
					txt_id.Clear();
					txt_ad.Clear();
					txt_soyad.Clear();
					txt_iletisim.Clear();
					txt_email.Clear();
					richTxt_adres.Clear();
					txt_yetki.Clear();
					txt_kresId.Clear();

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
		private void buttonKaydet_Click(object sender, EventArgs e)
		{
			Kaydet();
		}
	}
}
