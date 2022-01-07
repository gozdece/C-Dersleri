// See https://aka.ms/new-console-template for more information

Console.WriteLine("Recursive method öğrneği");
System.Console.WriteLine("5 sayısının faktöriyeli");

Methods methods = new Methods();
System.Console.WriteLine(methods.Fak(5));

string ifade ="Gözde cengiz";

Console.WriteLine(ifade.CheckSpaces());
Console.WriteLine(ifade.RemoveSpaces());

System.Console.WriteLine("Harfleri büyüt.");
System.Console.WriteLine(ifade.MakeUpperCase());
System.Console.WriteLine("Harfleri küçült");
System.Console.WriteLine(ifade.MakeLowerCase());

int[] dizi ={1,5,7,6};
System.Console.WriteLine("Diziyi ekrana yazdıralım");
dizi.EkranaYaz();

System.Console.WriteLine("Diziyi büyükten küçüğe sıralayalım");
dizi.SortArray();
dizi.EkranaYaz();

System.Console.WriteLine("Kelimenin ilk harfi");
System.Console.WriteLine(ifade.GetFirstCharacter());
class Methods{
    public int Fak(int a)
    {
        if(a<2)
            return a;
        return Fak(a-1)*a;
    }
}

public static class Extensions{

    public static bool CheckSpaces(this string s)
    {
        return s.Contains(" ");
    }

    public static string RemoveSpaces(this string s)
    {
        string[] dizi = s.Split(" ");
        return string.Join("",dizi);
    }

    public static string MakeUpperCase(this string s)
    {
        return s.ToUpper();
    } 

    public static string MakeLowerCase(this string s)
    {
        return s.ToLower();
    }

    public static void EkranaYaz(this int[] dizi)
    {
        foreach (var item in dizi)
        {
            System.Console.Write(item+" ");
        }
    }

    public static void SortArray(this int[] dizi)
    {
        Array.Sort(dizi);
    }

    public static string GetFirstCharacter(this string s)
    {
        return s.Substring(0,1);
    }
}