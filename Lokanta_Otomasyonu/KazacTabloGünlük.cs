using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu_1
{
    public partial class KazacTabloGünlük : Form
    {
        public KazacTabloGünlük()
        {
            InitializeComponent();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Çıkış Mı Yapmak İstiyorsunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            this.Hide();
            admin_Panel.Show();

        }

        private void KazacTabloGünlük_Load(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            try
            {
                SqlBaglanti.baglantiOpen();

                string sorgu = "SELECT * FROM MasaToplamları WHERE Tarih = @SecilenTarih";

                using (SqlCommand sqlCommand1 = new SqlCommand(sorgu, SqlBaglanti.baglan))
                {
                    sqlCommand1.Parameters.AddWithValue("@SecilenTarih", date);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }
    }
}
