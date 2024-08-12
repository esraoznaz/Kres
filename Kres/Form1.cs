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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		public int Yetki_Id
		{
			get
			{
				return Convert.ToInt32(txt_id.Text);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		void Giris()
		{
			YETKI yetki=new YETKI();
			yetki.Yetkili_eMail = txt_email.Text;
			yetki.Yetkili_Sifre = txt_sifre.Text;
			yetki.Aktif = true;
			
			
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True;";


			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT Yetki_turu FROM YETKI WHERE Yetkili_eMail = @eMail AND Yetkili_Sifre = @Sifre AND Yetki_Id=@Id";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@eMail", txt_email.Text);
				command.Parameters.AddWithValue("@Sifre", txt_sifre.Text);
				command.Parameters.AddWithValue("@Id", txt_id.Text);

				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read() )
				{
					string yetkili = reader["Yetki_turu"].ToString();
					if (yetkili == "Kreş Müdürü" && chkKresMuduru.Checked && yetki.Aktif == true )
					{ 
						// Kreş Müdürü ekranına yönlendir
						KresMudurAnasayfa kresMuduruForm = new KresMudurAnasayfa(this);
						kresMuduruForm.Show();
						this.Hide();
					}
					else if (yetkili == "Yönetici" && chkYetkili.Checked && yetki.Aktif == true)
					{
						// Yetkili ekranına yönlendir
						YetkiliAnasayfa yetkiliForm = new YetkiliAnasayfa();
						yetkiliForm.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Yetki seçimi yanlış! ya da aktif yetkili değilsiniz");
					}
				}
				else
				{
					MessageBox.Show("Kullanıcı Id, Kullanıcı Adı veya Şifre Yanlış!");
				}
				reader.Close();
			}
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			
			
			Giris();

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		
	}
}
