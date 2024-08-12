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
	public partial class YetkiliPersonelGuncel : Form
	{
		private PERSONEL personel;
		public YetkiliPersonelGuncel(PERSONEL personel)
		{
			InitializeComponent();
			this.personel = personel;
		}

		void Guncelle()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
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
					string guncelle = "UPDATE PERSONEL SET  Personel_Ad=@Ad, Personel_Soyad=@Soyad, Personel_Iletisim=@Iletisim, Personel_eMail=@eMail, Personel_Adres=@Adres, Personel_Yetki=@Yetki, Kres_Id=@KresId, Aktif=@Aktif WHERE Personel_Id=@Id";
					SqlCommand cmd = new SqlCommand(guncelle, connection);
					cmd.Parameters.AddWithValue("@Id", int.Parse(txt_id.Text));
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Soyad", txt_soyad.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@eMail", txt_email.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@Yetki", txt_yetki.Text);
					cmd.Parameters.AddWithValue("@Aktif", comboBox_aktif.Text);
					cmd.Parameters.AddWithValue("@KresId", int.Parse(txt_kresId.Text));
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
		private void buttonKaydet_Click(object sender, EventArgs e)
		{
			Guncelle();
		}

		private void YetkiliPersonelGuncel_Load(object sender, EventArgs e)
		{
			txt_id.Text = personel.Personel_Id.ToString();
			txt_ad.Text = personel.Personel_Ad;
			txt_soyad.Text = personel.Personel_Soyad;
			txt_iletisim.Text = personel.Personel_Iletisim;
			txt_email.Text = personel.Personel_eMail;
			richTxt_adres.Text = personel.Personel_Adres;
			txt_yetki.Text = personel.Personel_Yetki;
			txt_kresId.Text= personel.Kres_Id.ToString();
		}
	}
}
