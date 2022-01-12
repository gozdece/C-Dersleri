using System;

namespace _11._3.Ders.RecursiveExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive Ozyinelemeli methodlar

            var result = 2;
            for (int i = 1; i < 5; i++)
            {
                result *=2;
            }
            System.Console.WriteLine("2 uzeri 5 islemi sonucu:");
            System.Console.WriteLine(result);

            //method yoluyla us alma
            Islemler islem =new();
            System.Console.WriteLine("method ile us aldik:");
            System.Console.WriteLine(islem.Expo(2,5));

            //Extension Metodlar
            string ifade ="Gozde Cengiz";
            if (ifade.CheckSpaces())
                System.Console.WriteLine(ifade.RemoveSpaces());
                System.Console.WriteLine("ifadeyi buyut");
                System.Console.WriteLine(ifade.MakeUpperCase());
                System.Console.WriteLine("ifadeyi kucult");
                System.Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {1,5,20,34,6,43};
            dizi.EkranaYazdir();
            System.Console.WriteLine("siralayalim");
            dizi.SortArrray();
            dizi.EkranaYazdir();

            System.Console.WriteLine("3 sayisi cift mi degil mi bakalim");
            int sayi=3;
            if (sayi.IsEven())
            {
                System.Console.WriteLine("sayi cift");
            }else
            {
                System.Console.WriteLine("sayi cift degil");
            }

            string name="gozde";
            System.Console.WriteLine("gozde kelimesinin ilk harfini alalim");
            System.Console.WriteLine(name.GetFirstChar());
            

        }
    }

    public class Islemler{
        public int Expo(int sayi,int us)
        {
            if(us<2)
                return sayi;
            return Expo(sayi,us-1)*sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArrray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                System.Console.WriteLine(item);
            }
        }
        public static bool IsEven(this int param)
        {
            return param%2==0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
