// See https://aka.ms/new-console-template for more information

int a=2;
int b=3;

System.Console.WriteLine("Main classı içindeki topla metodu çalıştı:");
int sonuc = Topla(a,b);

Methods methods = new Methods();
System.Console.WriteLine("Ekrana yazdır metodunu çalıştırdık:");
methods.EkranaYazdir(Convert.ToString(sonuc));

System.Console.WriteLine("Şimdi değerleri birer arttırıp toplayalım:");
methods.DegerArttir(ref a,ref b);
System.Console.WriteLine("a ve b nin yeni değerlerini görelim: a:{0}, b:{1}",a,b);

static int Topla(int a, int b)
{
    return a+b;
}

class Methods{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void DegerArttir(ref int deger1, ref int deger2)
    {
        deger1++;
        deger2++;

    }
}