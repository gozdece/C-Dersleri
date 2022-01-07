// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Bir sayı girin:");
int sayi = int.Parse(Console.ReadLine());
int sayac=1;
int toplam =1;

while (sayac<sayi)
{
    sayac++;
     toplam+=sayac;
}
System.Console.WriteLine("Girilen sayıya kadar olan ortalama:"+toplam/sayac);

// a dan z ye kadar olan harfleri yazdıralım
char chr='a';
while (chr<='z')
{
     Console.Write(chr);
     chr++;
}

//FOREACH
string[] arabalar = {"BMW","Mercedes","Auid"};
foreach (var item in arabalar)
{
    System.Console.WriteLine(item);
    
}