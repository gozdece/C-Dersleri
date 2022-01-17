using System;

namespace _17.Ders.Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Cumartesi);
            System.Console.WriteLine((int)Gunler.Sali);
            
            int sicaklik =28;
            if (sicaklik<(int)HavaDurumu.Soguk)
            {
                System.Console.WriteLine("hava soguk altinda");
                
            }else if(sicaklik<(int)HavaDurumu.Normal && sicaklik>(int)HavaDurumu.Soguk)
            {
                System.Console.WriteLine("hava soguk ve normal arasinda");

            }else if(sicaklik<(int)HavaDurumu.Sicak && sicaklik>(int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("hava sicak ve normal arasinda");
            }else
            {
                System.Console.WriteLine("hava sicak");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal =15,
        Sicak =30
    }
}
