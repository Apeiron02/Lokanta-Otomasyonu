using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Lokanta_Otomasyonu_1
{
    internal class SqlBaglanti
    {
        public static SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-99AS8IF;Initial Catalog=LokantaOtomasyon1;Integrated Security=True");


        public static void  baglantiOpen()
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
        public static void  baglantiClose()
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
        

        
        public void CorbaADguncelle(string ad, string sıra)
        {
            baglantiOpen();
            SqlCommand CorbaAdGuncelle = new SqlCommand("update Corbalar set Corba_Adi='" + ad + "' where Sıra='" + sıra + "'", baglan);
            CorbaAdGuncelle.ExecuteNonQuery();
            
            baglantiClose();
        }
        public void CorbaFiyatguncelle(string fiyat,string sıra)
        {
            baglantiOpen();
            SqlCommand CorbaFiyatGuncelle = new SqlCommand("update Corbalar set Fiyat='" + fiyat + "' where Sıra='" + sıra + "'", baglan);
            CorbaFiyatGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void DurumADguncelle(string ad, string sıra)
        {
            baglantiOpen();
            SqlCommand DurumAdGuncelle = new SqlCommand("update Durumler set Durum_Adi='" + ad + "' where Sıra='" + sıra + "'", baglan);
            DurumAdGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void DurumFiyatguncelle(string fiyat, string sıra)
        {
            baglantiOpen();
            SqlCommand DurumFiyatGuncelle = new SqlCommand("update Durumler set Fiyat='" + fiyat + "' where Sıra='" + sıra + "'", baglan);
            DurumFiyatGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void KebapADguncelle(string ad, string sıra)
        {
            baglantiOpen();
            SqlCommand KebapAdGuncelle = new SqlCommand("update Kebaplar set Kebap_Adi='" + ad + "' where Sıra='" + sıra + "'", baglan);
            KebapAdGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void KebapFiyatguncelle(string fiyat, string sıra)
        {
            baglantiOpen();
            SqlCommand KebapFiyatGuncelle = new SqlCommand("update Kebaplar set Fiyat='" + fiyat + "' where Sıra='" + sıra + "'", baglan);
            KebapFiyatGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void PideADguncelle(string ad, string sıra)
        {
            baglantiOpen();
            SqlCommand PideAdGuncelle = new SqlCommand("update Pideler set Pide_Adi='" + ad + "' where Sıra='" + sıra + "'", baglan);
            PideAdGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void PideFiyatguncelle(string fiyat, string sıra)
        {
            baglantiOpen();
            SqlCommand PideFiyatGuncelle = new SqlCommand("update Pideler set Fiyat='" + fiyat + "' where Sıra='" + sıra + "'", baglan);
            PideFiyatGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void TatlıADguncelle(string ad, string sıra)
        {
            baglantiOpen();
            SqlCommand TatlıAdGuncelle = new SqlCommand("update Tatlılar set Tatlı_Adi='" + ad + "' where Sıra='" + sıra + "'", baglan);
            TatlıAdGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void TatlıFiyatguncelle(string fiyat, string sıra)
        {
            baglantiOpen();
            SqlCommand TatlıFiyatGuncelle = new SqlCommand("update Tatlılar set Fiyat='" + fiyat + "' where Sıra='" + sıra + "'", baglan);
            TatlıFiyatGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void İcecekADguncelle(string ad, string sıra)
        {
            baglantiOpen();
            SqlCommand İcecekAdGuncelle = new SqlCommand("update İcecekler set İcecek_Adi='" + ad + "' where Sıra='" + sıra + "'", baglan);
            İcecekAdGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        public void İcecekFiyatguncelle(string fiyat, string sıra)
        {
            baglantiOpen();
            SqlCommand İcecekFiyatGuncelle = new SqlCommand("update İcecekler set Fiyat='" + fiyat + "' where Sıra='" + sıra + "'", baglan);
            İcecekFiyatGuncelle.ExecuteNonQuery();
            baglantiClose();
        }
        
    }
}
