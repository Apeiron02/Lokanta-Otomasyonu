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
    public partial class PideDuzenle : Form
    {
        public PideDuzenle()
        {
            InitializeComponent();
        }

        private void PideDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetPideler.Pideler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pidelerTableAdapter.Fill(this.lokantaOtomasyon1DataSetPideler.Pideler);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string sıra = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();

            AdDegisTxt.Text = ad;
            FiyatDegisTxt.Text = fiyat;
            sıratextbox.Text = sıra;
        }
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(veriler, SqlBaglanti.baglan);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AdDegisBtn_Click(object sender, EventArgs e)
        {
            SqlBaglanti.baglantiOpen();
            SqlBaglanti sqlBaglanti = new SqlBaglanti();
            sqlBaglanti.PideADguncelle(AdDegisTxt.Text, sıratextbox.Text);
            MessageBox.Show("İsim Değiştirildi");
            verilerigoster("select * from Pideler");
            SqlBaglanti.baglantiClose();
        }

        private void FiyatDegisBtn_Click(object sender, EventArgs e)
        {
            SqlBaglanti.baglantiOpen();
            SqlBaglanti sqlBaglanti = new SqlBaglanti();
            sqlBaglanti.PideFiyatguncelle(FiyatDegisTxt.Text, sıratextbox.Text);
            MessageBox.Show("Fiyat Değiştirildi");
            verilerigoster("select * from Pideler");
            SqlBaglanti.baglantiClose();
        }
    }
}
