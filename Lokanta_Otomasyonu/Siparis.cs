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
    public partial class Siparis : Form
    {
        
        public Siparis()
        {
            InitializeComponent();
            customeDesign();
        }
        private void customeDesign()
        {
            PanelCorba.Visible = false;
            panelDurum.Visible = false;
            panelKebap.Visible = false;
            panelPide.Visible = false;
            panelTatlı.Visible = false;
            Panelİcecek.Visible = false;
        }
        private void HideSubMenu()
        {
            if (PanelCorba.Visible ==true) 
            {
                PanelCorba.Visible = false;
            }
            if (panelDurum.Visible == true)
            {
                panelDurum.Visible = false;
            }
            if (panelKebap.Visible == true)
            {
                panelKebap.Visible = false;
            }
            if (panelPide.Visible == true)
            {
                panelPide.Visible = false;
            }
            if (panelTatlı.Visible == true)
            {
                panelTatlı.Visible = false;
            }
            if (Panelİcecek.Visible == true)
            {
                Panelİcecek.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false) 
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void Siparis_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetİcecek.İcecekler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İceceklerTableAdapter.Fill(this.lokantaOtomasyon1DataSetİcecek.İcecekler);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetTatlı.Tatlılar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tatlılarTableAdapter.Fill(this.lokantaOtomasyon1DataSetTatlı.Tatlılar);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetPide.Pideler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pidelerTableAdapter.Fill(this.lokantaOtomasyon1DataSetPide.Pideler);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetKebap.Kebaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kebaplarTableAdapter.Fill(this.lokantaOtomasyon1DataSetKebap.Kebaplar);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetDurum.Durumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.durumlerTableAdapter.Fill(this.lokantaOtomasyon1DataSetDurum.Durumler);
            // TODO: Bu kod satırı 'lokantaOtomasyon1DataSetCorba.Corbalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.corbalarTableAdapter.Fill(this.lokantaOtomasyon1DataSetCorba.Corbalar);

        }

        private void Siparis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            Masalar masalar = new Masalar();
            this.Hide();
            masalar.Show();
        }


        private void corbalar_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelCorba);
        }

        private void durumler_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDurum);
        }

        private void kebaplar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKebap);
        }

        private void pideler_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPide);
        }

        private void tatlılar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTatlı);
        }

        private void icecekler_Click(object sender, EventArgs e)
        {
            showSubMenu(Panelİcecek);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string fiyat = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            
            textboxsiparis.Text = ad;
            textboxfiyat.Text = fiyat;
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView2.SelectedCells[0].RowIndex;
            string ad = dataGridView2.Rows[secilialan].Cells[0].Value.ToString();
            string fiyat = dataGridView2.Rows[secilialan].Cells[1].Value.ToString();

            textboxsiparis.Text = ad;
            textboxfiyat.Text = fiyat;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView3.SelectedCells[0].RowIndex;
            string ad = dataGridView3.Rows[secilialan].Cells[0].Value.ToString();
            string fiyat = dataGridView3.Rows[secilialan].Cells[1].Value.ToString();

            textboxsiparis.Text = ad;
            textboxfiyat.Text = fiyat;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView4.SelectedCells[0].RowIndex;
            string ad = dataGridView4.Rows[secilialan].Cells[0].Value.ToString();
            string fiyat = dataGridView4.Rows[secilialan].Cells[1].Value.ToString();

            textboxsiparis.Text = ad;
            textboxfiyat.Text = fiyat;
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView5.SelectedCells[0].RowIndex;
            string ad = dataGridView5.Rows[secilialan].Cells[0].Value.ToString();
            string fiyat = dataGridView5.Rows[secilialan].Cells[1].Value.ToString();

            textboxsiparis.Text = ad;
            textboxfiyat.Text = fiyat;
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView6.SelectedCells[0].RowIndex;
            string ad = dataGridView6.Rows[secilialan].Cells[0].Value.ToString();
            string fiyat = dataGridView6.Rows[secilialan].Cells[1].Value.ToString();

            textboxsiparis.Text = ad;
            textboxfiyat.Text = fiyat;
        }


        int toplamtutar = 0, n = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(textboxfiyat.Text);
            int adet = Convert.ToInt32(textboxadet.Text);
            int total = fiyat * adet;

            if (textboxsiparis.Text == null || textboxfiyat.Text ==null || textboxadet.Text == null)
            {
                MessageBox.Show("Metin Kutuları Boş Geçilemez !!");
            }
            dataGridSiparis.Rows.Add(++n, textboxsiparis.Text, textboxfiyat.Text, textboxadet.Text, total);
            textboxsiparis.Clear();
            textboxfiyat.Clear();
            textboxadet.Clear();
           

        }
        public void SetButtonText(char lastCharacter)
        {
            // İkinci formdaki butonun metnini güncelle
            label4.Text = lastCharacter.ToString();
        }

        private void cıkarbtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectrow = dataGridSiparis.SelectedRows[0];
            dataGridSiparis.Rows.Remove(selectrow);
            n--;
        }

        private void NakitBtn_Click(object sender, EventArgs e)
        {
            
            int sütunSırası = 4;

            foreach (DataGridViewRow row in dataGridSiparis.Rows)
            {
                
                if (row.Cells[sütunSırası].Value != null && int.TryParse(row.Cells[sütunSırası].Value.ToString(), out int fiyatlar))
                {
                    toplamtutar += fiyatlar;
                }
            }
            SqlBaglanti.baglantiOpen();
            DateTime date = DateTime.Now;
            string masatoplamkayıt = "INSERT INTO MasaToplamları (MasaToplam,Tarih) VALUES (@MasaToplam,@Tarih)";

            SqlCommand sqlCommand1 = new SqlCommand(masatoplamkayıt, SqlBaglanti.baglan);
            sqlCommand1.Parameters.AddWithValue("@MasaToplam", toplamtutar);
            sqlCommand1.Parameters.AddWithValue("@Tarih", date);
            sqlCommand1.ExecuteNonQuery();
            SqlBaglanti.baglantiClose();


            SqlBaglanti.baglantiOpen();
            
            

            foreach(DataGridViewRow row in dataGridSiparis.Rows)
            {
                try
                {

                    DateTime dateTime = DateTime.Now;
                    string MasaNo = label4.Text.ToString();
                    int sıra = Convert.ToInt32(row.Cells["Sıra"].Value.ToString()); 
                    string ad = row.Cells["Ad"].Value.ToString();
                    int fiyat = Convert.ToInt32(row.Cells["Fiyat"].Value);
                    int adet = Convert.ToInt32(row.Cells["Adet"].Value);
                    int total = fiyat * adet;


                    string komut = "INSERT INTO Siparis (MasaNo,Sıra,Urun_Adi,Urun_Fiyat,Adet,ToplamFiyat,Tarih) VALUES (@MasaNo,@Sıra,@Urun_Adi,@Urun_Fiyat,@Adet,@ToplamFiyat,@Tarih)";

                    using (SqlCommand sqlCommand = new SqlCommand(komut, SqlBaglanti.baglan))

                    {
                        sqlCommand.Parameters.AddWithValue("@MasaNo", MasaNo);
                        sqlCommand.Parameters.AddWithValue("@Sıra",sıra);
                        sqlCommand.Parameters.AddWithValue("@Urun_Adi", ad);
                        sqlCommand.Parameters.AddWithValue("@Urun_Fiyat", fiyat);
                        sqlCommand.Parameters.AddWithValue("@Adet", adet);
                        sqlCommand.Parameters.AddWithValue("@ToplamFiyat", total);
                        sqlCommand.Parameters.AddWithValue("@Tarih", dateTime);

                        sqlCommand.ExecuteNonQuery();
                        
                    }
                }
                catch(Exception ex)
                {
                    
                }   
                
            }

            SqlBaglanti.baglantiClose();
            dataGridSiparis.Rows.Clear();

            MessageBox.Show("Kayıt Gerçekleşti");
            
            
        }
    }
}
