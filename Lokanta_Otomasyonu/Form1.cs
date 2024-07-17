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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string kullaniciadi;
            string sifre;
            Person person = new Person();
            kullaniciadi = person.SetKullaniciAdi(kullanicibox.Text);
            sifre = person.SetSifre(sifrebox.Text);
            SqlBaglanti.baglantiOpen();
            //bool kayitli_mi = false;
            try
            {
                SqlCommand kontrol = new SqlCommand("SELECT rol FROM Person WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre", SqlBaglanti.baglan);
                kontrol.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                kontrol.Parameters.AddWithValue("@sifre", sifre);

                object result = kontrol.ExecuteScalar(); // Sorgudan dönen değeri al

                if (result != null && result != DBNull.Value)
                {
                    
                    bool rol = Convert.ToBoolean(result); // object tipindeki değeri bool'a çevir

                    if (rol)
                    {
                        timer1.Start();

                    }
                    else
                    {
                        timer2.Start();

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                SqlBaglanti.baglantiClose();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniKayit yeniKayit = new YeniKayit();
            this.Hide();
            yeniKayit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 5;
            progressBar1.Value = sayac;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Masalar ms = new Masalar();
                this.Hide();
                ms.Show();
               
            }
            
        }

        
        int n = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            n += 5;
            progressBar1.Value = n;
            if(progressBar1.Value == progressBar1.Maximum) 
            {
                progressBar1.Value = 0;
                timer2.Stop();
                Admin_Panel admin_Panel = new Admin_Panel();
                this.Hide();
                admin_Panel.Show();
            }
        }
    }
}
