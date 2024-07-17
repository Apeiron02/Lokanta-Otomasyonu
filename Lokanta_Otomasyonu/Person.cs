using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lokanta_Otomasyonu_1
{
    internal class Person
    {
        

        public string SetAd(string ad)
        {
            Regex regex = new Regex("^[0-9]*$");
            Regex ozelKarakterRegex = new Regex("[^a-zA-Z0-9]");
            if (regex.IsMatch(ad) || ad == null || ad == "" || ozelKarakterRegex.IsMatch(ad))
            {
                ad = "HATALI";
            }


            return ad;
        }
        
        public string SetSoyad(string soyad)
        {
            Regex regex = new Regex("^[0-9]*$");

            if (regex.IsMatch(soyad) || soyad == null || soyad == "")
            {
                soyad = "HATALI";
            }

            return soyad;
        }
        public string SetKullaniciAdi(string kullaniciAdi)
        {
            if (kullaniciAdi == null || kullaniciAdi == "")
            {
                kullaniciAdi = "HATALI";
            }


            return kullaniciAdi;
        }
        public string SetSifre(string sifre)
        {
            bool harfVarMı = sifre.Any(char.IsLetter);
            bool sayıVarMı = sifre.Any(char.IsDigit);

            if (!harfVarMı || !sayıVarMı)
            {
                sifre = "HATALI";
            }

            return sifre;
        }
        public string SetMail(string mail)
        {

            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (mail == null || !(regex.IsMatch(mail)))
            {
                mail = "HATALI";
            }


            return mail;

        }
        public bool SetRol(bool rol)
        {
            return rol;
        }
        public Person()
        {

        }

    }

}

