using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("4");


        Mesaj msj = new Mesaj();
        msj.metin();
        Console.ReadLine();

        islem İs = new islem();
        İs.topla(8, 7);

        Kimlik KM = new Kimlik();
        Console.WriteLine(KM.AD);

        Kisiler KS = new Kisiler();
        KS.kisilistesi("A", 8, "M");

        Ogrenci ogr = new Ogrenci("Ders");
        ogr.yazdir = "Ders";
        Console.WriteLine(ogr.yazdir);
    }
}


