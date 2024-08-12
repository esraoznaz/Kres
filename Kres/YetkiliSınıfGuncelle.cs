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
	public partial class YetkiliSınıfGuncelle : Form
	{
		private SINIF sınıf;
		private KRESLER seciliKutu;

		public YetkiliSınıfGuncelle(SINIF sınıf)
		{
			InitializeComponent();
			this.sınıf = sınıf;
		}

		public YetkiliSınıfGuncelle(KRESLER seciliKutu)
		{
			this.seciliKutu = seciliKutu;
		}

		void Guncelle()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				if (connection.State == System.Data.ConnectionState.Open)
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
					string guncelle = "UPDATE SINIF SET  Sınıf_Id=@SınıfId, Sınıf_Ad=@SınıfAd, Sınıf_Kontenjan=@Kontenjan, Personel_Id=@PersonelId ,Kres_Id=@Kres_Id, Aktif=@Aktif  WHERE Sınıf_Id=@SınıfId";
					SqlCommand cmd = new SqlCommand(guncelle, connection);
					cmd.Parameters.AddWithValue("@SınıfId", Convert.ToInt32(txt_sınıfId.Text));
					cmd.Parameters.AddWithValue("@SınıfAd", txt_sınıfAd.Text);
					cmd.Parameters.AddWithValue("@Kontenjan", txt_sınıfKontenjan.Text);
					cmd.Parameters.AddWithValue("@PersonelId", txt_personelId.Text);
					cmd.Parameters.AddWithValue("@Kres_Id", txt_kresID.Text);
					cmd.Parameters.AddWithValue("@Aktif", Convert.ToInt32(comboBox_aktif.Text));
					int rowsAffected = cmd.ExecuteNonQuery();
					if (rowsAffected > 0)
					{
						MessageBox.Show("Güncelleme İşilemi Tamamlandı.");
					}
					else
					{
						MessageBox.Show("Güncelleme Hatası ");
					}
					connection.Close();
				}
			}
		}
		private void buttonGuncelle_Click(object sender, EventArgs e)
		{
			Guncelle();
		}

		private void YetkiliSınıfGuncelle_Load(object sender, EventArgs e)
		{
			txt_sınıfId.Text = sınıf.Sınıf_Id.ToString();
			txt_sınıfAd.Text = sınıf.Sınıf_Ad;
			txt_sınıfKontenjan.Text = sınıf.Sınıf_Kontenjan.ToString();
			txt_personelId.Text = sınıf.Personel_Id.ToString();
			txt_kresID.Text = sınıf.Kres_Id.ToString();
			
		}
	}
}
