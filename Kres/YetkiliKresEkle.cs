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
	public partial class YetkiliKresEkle : Form
	{
		public YetkiliKresEkle()
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
						string.IsNullOrWhiteSpace(richTxt_adres.Text) ||
						string.IsNullOrWhiteSpace(txt_kontenjan.Text) ||
						string.IsNullOrWhiteSpace(txt_iletisim.Text) ||
						string.IsNullOrWhiteSpace(comboBox_aktif.Text) )

					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return;
					}

					SqlCommand cmd = new SqlCommand("INSERT INTO KRESLER(Kres_Id,Kres_Ad, Kres_Adres, Kres_Kontenjan, Kres_İletisim, Aktif) VALUES (@ID, @Ad, @Adres, @Kontenjan, @Iletisim, @Aktif)", con);


					cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txt_id.Text));
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@Kontenjan", txt_kontenjan.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@Aktif", Convert.ToInt32(comboBox_aktif.Text));
					txt_id.Clear();
					txt_ad.Clear();
					richTxt_adres.Clear();
					txt_kontenjan.Clear();
					txt_iletisim.Clear();
					

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

		private void button1_Click(object sender, EventArgs e)
		{
			Kaydet();

		}

        private void YetkiliKresEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
