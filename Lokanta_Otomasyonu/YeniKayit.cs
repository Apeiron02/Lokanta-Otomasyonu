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
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdBox_TextChanged(object sender, EventArgs e)
        {
            
            


            
        }

        private void KayıtButton_Click(object sender, EventArgs e)
        {
            string ad;
            string soyad;
            string kullaniciadi;
            string sifre;
            string mail;
            bool rol;
            Person person = new Person();

            ad = person.SetAd(AdBox.Text);
            soyad = person.SetSoyad(SoyadBox.Text);
            kullaniciadi = person.SetKullaniciAdi(KAdiBox.Text);
            sifre = person.SetSifre(SifreBox.Text);
            mail = person.SetMail(MailBox.Text);
            rol = person.SetRol(RolARadioButton.Checked);


            SqlBaglanti.baglantiOpen();

            string query = "SELECT COUNT(*) FROM Person WHERE kullaniciadi = @kullaniciadi";

            if (ad == "HATALI" || soyad == "HATALI" || kullaniciadi == "HATALI" || sifre == "HATALI" || mail == "HATALI")
            {
                MessageBox.Show("Yanlış Bir şeyler var !!");
            }
            
            else
            {
                using (SqlCommand cmd = new SqlCommand(query, SqlBaglanti.baglan))
                {
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);

                    int kayitSayisi = (int)cmd.ExecuteScalar();

                    if (kayitSayisi > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanımda.");
                    }
                    else
                    {
                        // Eğer kullanıcı adı daha önce kayıtlı değilse, yeni kayıt işlemini gerçekleştir
                        PersonDB.PERSONEKLE.PersonEkle(ad, soyad, kullaniciadi, sifre, mail, rol);
                        MessageBox.Show("Kayıt gerçekleşti");
                    }
                }
            }

            SqlBaglanti.baglantiClose();


        }

        private void YeniKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btngeri_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.Show();
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
