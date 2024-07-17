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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void Corba_Click(object sender, EventArgs e)
        {
            CorbaDuzenle corbaDuzenle = new CorbaDuzenle();
            this.Hide();
            corbaDuzenle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KebapDuzenle kebapDuzenle = new KebapDuzenle();
            this.Hide();
            kebapDuzenle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PideDuzenle pideDuzenle =  new PideDuzenle();
            this.Hide();
            pideDuzenle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DurumDuzenle durumDuzenle = new DurumDuzenle();
            this.Hide();
            durumDuzenle.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TatlıDuzenle tatlıDuzenle = new TatlıDuzenle();
            this.Hide();
            tatlıDuzenle.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IcecekDuzenle ıcecekDuzenle = new IcecekDuzenle();
            this.Hide();
            ıcecekDuzenle.Show();
        }

        private void Admin_Panel_FormClosed(object sender, FormClosedEventArgs e)
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
            Giris giris = new Giris();
            this.Hide();
            giris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KazacTabloGünlük kazacTabloGünlük = new KazacTabloGünlük();
            this.Hide();
            kazacTabloGünlük.Show();
        }

        private void tumsiparisbtn_Click(object sender, EventArgs e)
        {
            TumSiparisler tumSiparisler = new TumSiparisler();
            this.Hide();
            tumSiparisler.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TumPersonel tumPersonel = new TumPersonel();
            this.Hide();
            tumPersonel.Show();
        }
    }
}
