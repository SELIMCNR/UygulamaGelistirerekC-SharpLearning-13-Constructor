using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Mesaj
    {
            public void metin()
            {
                Console.WriteLine("Merhaba Ankara");
                Console.Write("Merhaba elazığ");
                Kisiler ks = new Kisiler();
                string isim;
                int yas;
                string meslek;
                Console.WriteLine("isim gir");
                isim = Console.ReadLine();

                Console.WriteLine("Yas gir ");
                yas = Convert.ToInt32(Console.ReadLine());

                meslek = Console.ReadLine();
                ks.kisilistesi(isim, yas, meslek);

                islem isl = new islem();
                isl.topla(5, 8);

                string blg;
                Console.WriteLine("Ad - Kulüp : ");
                blg = Console.ReadLine();
                Ogrenci ogr = new Ogrenci(blg);
                Console.ReadLine();

                Kimlik kml = new Kimlik();
                kml.AD = "SELİM";
                kml.SOYAD = "Çınar";
                kml.MEMLEKET = "Kahramanmaraş";
                kml.CINSIYET = 'E';
                Console.WriteLine(kml.AD);
                Console.WriteLine(kml.SOYAD);
                Console.WriteLine(kml.MEMLEKET);
                Console.WriteLine(kml.YAS);
                Console.WriteLine(kml.CINSIYET);
            }
        }

    }

