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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Kres
{
	public partial class KresMudurSınıfcs : Form
	{
		public Form1 _form1 = new Form1();
		public KresMudurSınıfcs(Form1 form1)
		{
			InitializeComponent();
			_form1 = form1;
		}
		SqlDataAdapter adapter;
		DataSet ds;
		void SınıfListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				if (conn.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					int YetkiId = _form1.Yetki_Id;
					SqlCommand cmd = new SqlCommand("SELECT * FROM SINIF WHERE Kres_Id = (SELECT Kres_Id FROM YETKI  WHERE Yetki_Id =@YetkiId )", conn);
					adapter = new SqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
					ds = new DataSet();
					adapter.Fill(ds, "SINIF");
					dataGridView1.DataSource = ds.Tables["SINIF"];

				}
					
			}
		}
		private void KresMudurSınıfcs_Load(object sender, EventArgs e)
		{
			SınıfListele();
		}

		void AktifSınıfListele()
		{
			string connectionString = "Server=LAPTOP-3H9G77VD\\SQLEXPRESS;Database=Kres;Integrated Security=True";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				if (conn.State == System.Data.ConnectionState.Open)
				{
					DataTable dt = new DataTable();
					int YetkiId = _form1.Yetki_Id;
					SqlCommand cmd = new SqlCommand("SELECT * FROM SINIF WHERE Kres_Id = (SELECT Kres_Id FROM YETKI  WHERE Yetki_Id =@YetkiId ) AND Aktif=1", conn);
					adapter = new SqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("@YetkiId", YetkiId);
					ds = new DataSet();
					adapter.Fill(ds, "SINIF");
					dataGridView1.DataSource = ds.Tables["SINIF"];

				}

			}

		}

		private void button_aktifSınıf_Click(object sender, EventArgs e)
		{
			AktifSınıfListele();
		}
	}
}
