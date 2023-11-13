using System;

class Program
{
    static void Main() {
        Console.WriteLine("4");

        
        Mesaj msj = new Mesaj();
        msj.metin();
        Console.ReadLine();
    }
}

class Mesaj{
    
    public   void metin(){
        Console.WriteLine("Merhaba Ankara");
        Console.Write("Merhaba elazığ");
        kisiler ks = new kisiler();
        string isim;
        int yas;
        string meslek;
        Console.Write("isim gir");
        isim = Console.ReadLine();
   
        Console.Write("Yas gir ");
        yas = Convert.ToInt32( Console.ReadLine());
        
        meslek = Console.ReadLine();
        ks.kisilistesi(isim,yas,meslek);

        islem isl =new islem();
        isl.topla(5,8);
       
        string blg;
        Console.Write("Ad - Kulüp : ");
        blg = Console.ReadLine();
        Ogrenci ogr = new Ogrenci(blg);
         Console.ReadLine();
         
        Kimlik kml = new Kimlik();
        kml.AD = "SELİM";
        kml.SOYAD="Çınar";
        kml.MEMLEKET = "Kahramanmaraş";
        kml.CINSIYET='E';
        Console.WriteLine(kml.AD);
         Console.WriteLine(kml.SOYAD);
          Console.WriteLine(kml.MEMLEKET);
           Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
    }
}

class kisiler{
    public void kisilistesi(string adsoyad,int yaş,string meslek){
        for(int i =0 ; i<15;i++){
              Console.WriteLine(adsoyad+yaş+meslek);
        }
      
    }
}
class islem{
    public int topla(int s1 ,int s2){
        int s3 = s1+s2;
        Console.Write("Sonuc : "+s3);
        return s3;
    }
}
class Ogrenci{
    public Ogrenci(string bilgi){
        Console.WriteLine(bilgi);
    }
}

class Kimlik{
    //Properties
    string ad;
    string soyad;
    string memleket;
    int yas;
    char cinsiyet;
    
    //Encapsulation
  public  string AD {
        get {return ad;}
        set {ad = value.ToLower();}
    }
 public  string SOYAD {
        get {return soyad;}
        set {soyad = value.ToUpper(); }
    }
    
     public  string MEMLEKET {
        get {return memleket;}
        set {memleket = value.ToUpper(); }
    }
     public  int YAS {
        get {return yas;}
        set {yas = Math.Abs(value); }
    }
     public  char CINSIYET {
        get {return cinsiyet;}
        set {cinsiyet = value; }
    }
    
    //Constructor
    public Kimlik(){
        ad ="";
        soyad="";
        yas =22;
        cinsiyet ='k';
        memleket = "Ankara";
    }
    
    
}