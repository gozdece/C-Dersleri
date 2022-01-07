// See https://aka.ms/new-console-template for more information

string sayi ="999";

bool sonuc = int.TryParse(sayi,out int outSayi);

if(sonuc)
    System.Console.WriteLine("String olan sayıyı çevirdim:"+outSayi);
else    
    System.Console.WriteLine("Başarısız.");


Methods methods = new Methods();
methods.Topla(3,5,out int toplam);
System.Console.WriteLine("Topla methodu ile yaptığımız işlemin sonucu: {0}",toplam);

//Methods Overloading
System.Console.WriteLine("ekranayazdır metodu int değer alıyor:");
methods.EkranaYazdir(5);
System.Console.WriteLine("ekranayazdır metodu string değer alıyor:");
methods.EkranaYazdir("hey");
class Methods{
    public void Topla(int a,int b,out int outToplam)
    {
        outToplam = a+b;
    }
    
    public void EkranaYazdir(string veri)
    {
        System.Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        System.Console.WriteLine(veri);
    }
}