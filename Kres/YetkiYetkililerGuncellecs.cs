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
	public partial class YetkiYetkililerGuncellecs : Form
	{
		private YETKI yetki;
		public YetkiYetkililerGuncellecs(YETKI yetki)
		{
			InitializeComponent();
			this.yetki = yetki;	
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
					string guncelle = "UPDATE YETKI SET Yetki_Id=@Id, Yetki_turu=@Tur, Yetkili_ad=@Ad, Yetkili_Iletisim=@Iletisim, Yetkili_Adres=@Adres, Yetkili_eMail=@Mail, Yetkili_Sifre=@Sifre, Aktif=@Aktif, Kres_Id=@KresId WHERE Yetki_Id=@Id";
					SqlCommand cmd = new SqlCommand(guncelle, connection);
					cmd.Parameters.AddWithValue("@Id", int.Parse(txt_id.Text));
					cmd.Parameters.AddWithValue("@Tur", txt_turu.Text);
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@Mail", txt_email.Text);
					cmd.Parameters.AddWithValue("@Sifre", txt_sifre.Text);
					cmd.Parameters.AddWithValue("@Aktif", comboBox_aktif.Text);
					cmd.Parameters.AddWithValue("@KresId", txt_kresId.Text);


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

		private void button_guncelle_Click(object sender, EventArgs e)
		{
			Guncelle();
		}

		private void YetkiYetkililerGuncellecs_Load(object sender, EventArgs e)
		{
			txt_id.Text = yetki.Yetki_Id.ToString();
			txt_turu.Text = yetki.Yetki_turu;
			txt_ad.Text = yetki.Yetkili_ad;
			txt_iletisim.Text = yetki.Yetkili_Iletisim;
			richTxt_adres.Text = yetki.Yetkili_Adres;
			txt_email.Text = yetki.Yetkili_eMail;
			txt_sifre.Text = yetki.Yetkili_Sifre;
			//txt_kresId.Text = yetki.Kres_Id.ToString();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
