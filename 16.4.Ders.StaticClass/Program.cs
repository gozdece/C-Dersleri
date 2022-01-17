using System;

namespace _16._4.Ders.StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("calisan sayisi : {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("gozde","cengiz","yazilim");
             System.Console.WriteLine("calisan sayisi : {0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("simge","cengiz","yazilim");
            Calisan calisan2 = new Calisan("deniz","cengiz","yazilim");
            System.Console.WriteLine("calisan sayisi : {0}",Calisan.CalisanSayisi);

            System.Console.WriteLine("*******");
            System.Console.WriteLine(Islemler.Cikar(100,50));
            System.Console.WriteLine(Islemler.Topla(20,70));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;
        
        static Calisan()
        {
            calisanSayisi =0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
