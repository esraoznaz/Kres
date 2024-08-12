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
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kres
{ 
	public partial class YetkiliKresGuncelle : Form
	{
		private KRESLER kresler;
		public YetkiliKresGuncelle(KRESLER kresler)
		{
			InitializeComponent();
			this.kresler = kresler;
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
						string.IsNullOrWhiteSpace(richTxt_adres.Text) ||
						string.IsNullOrWhiteSpace(txt_kontenjan.Text) ||
						string.IsNullOrWhiteSpace(txt_iletisim.Text) ||
						string.IsNullOrWhiteSpace(comboBox_aktif.Text))

					{
						MessageBox.Show("Lütfen tüm alanları doldurunuz.");
						return;
					}
					string guncelle = "UPDATE KRESLER SET  Kres_Id=@KresId, Kres_Ad=@Ad, Kres_Adres=@Adres, Kres_Kontenjan=@Kontenjan, Kres_İletisim=@Iletisim, Aktif=@Aktif  WHERE Kres_Id=@KresId";
					SqlCommand cmd = new SqlCommand(guncelle, connection);
					cmd.Parameters.AddWithValue("@KresId", int.Parse(txt_id.Text));
					cmd.Parameters.AddWithValue("@Ad", txt_ad.Text);
					cmd.Parameters.AddWithValue("@Adres", richTxt_adres.Text);
					cmd.Parameters.AddWithValue("@Kontenjan", int.Parse (txt_kontenjan.Text));
					cmd.Parameters.AddWithValue("@Iletisim", txt_iletisim.Text);
					cmd.Parameters.AddWithValue("@Aktif", comboBox_aktif.Text);
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
		private void button_Guncelle_Click(object sender, EventArgs e)
		{
			Guncelle();
		}

		private void YetkiliKresGuncelle_Load(object sender, EventArgs e)
		{
			txt_id.Text = kresler.Kres_Id.ToString();
			txt_ad.Text = kresler.Kres_Ad;
			richTxt_adres.Text = kresler.Kres_Adres;
			txt_kontenjan.Text = kresler.Kres_Kontenjan.ToString();
			txt_iletisim.Text = kresler.Kres_İletisim;
			comboBox_aktif.Text = kresler.Aktif.ToString();
		}	
	}
}