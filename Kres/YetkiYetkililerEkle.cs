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
	public partial class YetkiYetkililerEkle : Form
	{
		public YetkiYetkililerEkle()
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
						string.IsNullOrWhiteSpace(txt_turu.Text) ||
						string.IsNullOrWhiteSpace(txt_ad.Text) ||
						string.IsNullOrWhiteSpace(txt_iletisim.Text) ||
						string.IsNullOrWhiteSpace(richTxt_adres.Text) ||
						string.IsNullOrWhiteSpace(txt_email.Text) ||
						string.IsNullOrWhiteSpace(txt_sifre.Text) ||
						string.IsNullOrWhiteSpace(comboBox_aktif.Text))

					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return;
					}

					SqlCommand cmd = new SqlCommand("INSERT INTO YETKI(Yetki_Id,Yetki_turu, Yetkili_ad, Yetkili_Iletisim, Yetkili_Adres, Yetkili_eMail, Yetkili_Sifre , Aktif, Kres_Id) VALUES (@ID, @Turu, @Ad, @Iletisim, @Adres, @Email, @Sifre, @Aktif, @KresId)", con);


					cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_id.Text));
					cmd.Parameters.AddWithValue("@Turu", txt_turu.Text);
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@Email", txt_email.Text);
					cmd.Parameters.AddWithValue("@Sifre", txt_sifre.Text);
					cmd.Parameters.AddWithValue("@Aktif", Convert.ToInt32(comboBox_aktif.Text));
					cmd.Parameters.AddWithValue("@KresId", txt_kresId.Text);
					txt_id.Clear();
					txt_turu.Clear();
					txt_ad.Clear();
					txt_iletisim.Clear();
					richTxt_adres.Clear();
					txt_email.Clear();
					txt_sifre.Clear();
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

		private void button_kaydet_Click(object sender, EventArgs e)
		{
			Kaydet();
		}

        private void YetkiYetkililerEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
