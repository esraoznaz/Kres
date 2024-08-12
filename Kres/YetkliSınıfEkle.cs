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
	public partial class YetkliSınıfEkle : Form
	{
		public YetkliSınıfEkle()
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
					if (string.IsNullOrWhiteSpace(txt_sınıfId.Text) ||
						string.IsNullOrWhiteSpace(txt_sınıfAd.Text) ||
						string.IsNullOrWhiteSpace(txt_sınıfKontenjan.Text) ||
						string.IsNullOrWhiteSpace(txt_personelId.Text) ||
						string.IsNullOrWhiteSpace(txt_kresID.Text) ||
						string.IsNullOrWhiteSpace(comboBox_aktif.Text))

					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return;
					}

					SqlCommand cmd = new SqlCommand("INSERT INTO SINIF (Sınıf_Id, Sınıf_Ad, Sınıf_Kontenjan, Personel_Id,Kres_Id, Aktif) VALUES (@SınıfId, @SınıfAd, @Kontenjan, @PersonelId,@Kres_Id, @Aktif)", con);


					cmd.Parameters.AddWithValue("@SınıfId", Convert.ToInt32(txt_sınıfId.Text));
					cmd.Parameters.AddWithValue("@SınıfAd", txt_sınıfAd.Text);
					cmd.Parameters.AddWithValue("@Kontenjan", txt_sınıfKontenjan.Text);
					cmd.Parameters.AddWithValue("@PersonelId", txt_personelId.Text);
					cmd.Parameters.AddWithValue("@Kres_Id", txt_kresID.Text);
					cmd.Parameters.AddWithValue("@Aktif", Convert.ToInt32(comboBox_aktif.Text));
					txt_sınıfId.Clear();
					txt_sınıfAd.Clear();
					txt_sınıfKontenjan.Clear();
					txt_personelId.Clear();
					txt_kresID.Clear();
					

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
			Kaydet();
		}

        private void YetkliSınıfEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
