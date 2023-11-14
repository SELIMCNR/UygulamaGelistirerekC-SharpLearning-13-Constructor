using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kimlik
    {
        //Properties
        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        //Encapsulation
        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value.ToUpper(); }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public char CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        //Constructor
        public Kimlik()
        {
            ad = "";
            soyad = "";
            yas = 22;
            cinsiyet = 'k';
            memleket = "Ankara";
        }


    }
}
    
