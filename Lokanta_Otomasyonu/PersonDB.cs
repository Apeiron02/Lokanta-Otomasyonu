using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu_1
{
    internal class PersonDB
    {

        public static SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-99AS8IF;Initial Catalog=LokantaOtomasyon1;Integrated Security=True");

        public static void baglantiOpen()
        {

            if (baglan.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    baglan.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static void baglantiClose()
        {
            if (baglan.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    baglan.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public class PERSONEKLE
        {
            public static void PersonEkle(string ad, string soyad, string kullaniciAdi, string sifre, string mail,bool rol)
            //public static void AdEkle(string ad)
            {
                baglantiOpen();
                //SqlCommand komut = new SqlCommand("INSERT INTO Person (ad) VALUES (@Ad)", baglan);
                SqlCommand komut = new SqlCommand("INSERT INTO Person (ad,soyad,kullaniciadi,sifre,mail,rol) VALUES(@ad,@soyad,@kullaniciadi,@sifre,@mail,@rol)", baglan);

                komut.Parameters.AddWithValue("@Ad", ad);
                komut.Parameters.AddWithValue("@Soyad", soyad);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@Sifre", sifre);
                komut.Parameters.AddWithValue("@Mail", mail);
                komut.Parameters.AddWithValue("@Rol", rol);
                komut.ExecuteNonQuery();
                baglantiClose();
            }
            
        }
        
    }
}
