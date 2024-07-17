using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu_1
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }
        private char GetLastCharacter(string text)
        {
            // Verilen metnin son karakterini al
            if (!string.IsNullOrEmpty(text))
            {
                return text[text.Length - 1];
            }
            return '\0';
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        public static string AdTutma;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa1.Text));
            
            this.Hide();
            siparis.Show();

        }

        private void masa2_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa2.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa3_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa3.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa4_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa4.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa5_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa5.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa6.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa7_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa7.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa8_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa8.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa9_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa9.Text));
            this.Hide();
            siparis.Show();
        }

        private void masa10_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SetButtonText(GetLastCharacter(masa10.Text));
            this.Hide();
            siparis.Show();
        }

        private void Masalar_Load(object sender, EventArgs e)
        {

        }

        
        

        private void button1_Click_1(object sender, EventArgs e)
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
            Giris giris = new Giris();
            this.Hide();
            giris.Show();
        }
    }
}
