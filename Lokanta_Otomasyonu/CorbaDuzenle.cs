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
    public partial class CorbaDuzenle : Form
    {
        public CorbaDuzenle()
        {
            InitializeComponent();
        }

        private void CorbaDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSet1.Corbalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.corbalarTableAdapter2.Fill(this.lokantaOtomasyon1DataSet1.Corbalar);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetCorbalar.Corbalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.corbalarTableAdapter1.Fill(this.lokantaOtomasyon1DataSetCorbalar.Corbalar);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSet.Corbalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.corbalarTableAdapter.Fill(this.lokantaOtomasyon1DataSet.Corbalar);

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
        
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(veriler,SqlBaglanti.baglan);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void adDegis_Click(object sender, EventArgs e)
        {
            
            SqlBaglanti.baglantiOpen();
            SqlBaglanti sqlBaglanti = new SqlBaglanti();
            sqlBaglanti.CorbaADguncelle(textBox1.Text, textBox3.Text);
            MessageBox.Show("İsim Değiştirildi");
            verilerigoster("select * from Corbalar");
            SqlBaglanti.baglantiClose();



        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string sıra = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = fiyat;
            textBox3.Text = sıra;
        }

        

        private void fiyatDegis_Click(object sender, EventArgs e)
        {
            SqlBaglanti sqlBaglanti = new SqlBaglanti();
            sqlBaglanti.CorbaFiyatguncelle(textBox2.Text, textBox3.Text);
            MessageBox.Show("Fiyat Değiştirildi!!");
            verilerigoster("select * from Corbalar");
            SqlBaglanti.baglantiClose();

        }

        private void GuncelTablo_Click(object sender, EventArgs e)
        {

        }
    }
}
