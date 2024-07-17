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
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
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

        private void TumSiparisler_Load(object sender, EventArgs e)
        {
            

            try
            {
                SqlBaglanti.baglantiOpen();

                string komut = ("SELECT Urun_Adi,Urun_Fiyat,Adet,ToplamFiyat FROM Siparis ");
                
                using (SqlCommand command = new SqlCommand(komut, SqlBaglanti.baglan))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                SqlBaglanti.baglantiClose();
            }

            catch (Exception ex) 
            {
                MessageBox.Show("HATA :" +ex.Message);
            }


        }
    }
}
