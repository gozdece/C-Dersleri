// See https://aka.ms/new-console-template for more information

//Dizi tanımlama
string[] renkler = new string[5];

string[] hayvanlar = {"Kedi","Kopek","Kuş"};

int[] dizi;
dizi = new int[5];

//Dizilere Değer Atama ve Erişim
renkler[0] ="Mavi";
dizi[3]=10;

System.Console.WriteLine(hayvanlar[1]);
System.Console.WriteLine(dizi[3]);

//Döngülerle dizi kullanılması
//Klavyeden girilen n tane sayının ortalamasını hesaplayan program
System.Console.Write("Diziniz kaç elemanlı olsun:");
int diziUzunluk = int.Parse(Console.ReadLine());
int[] dizi1 = new int[diziUzunluk];

for (int i = 0; i <diziUzunluk; i++)
{
    System.Console.Write("Dizinin {0}. elemanını girin",(i+1));
    dizi1[i]=int.Parse(Console.ReadLine());
}
System.Console.WriteLine("Dizinin Elemanları:");
int sayac=0;
int toplam=0;
foreach (var item in dizi1)
{
    sayac++;
    toplam+=item;
    System.Console.WriteLine("Dizinin {0}. elemanı {1}",sayac,item);
}
System.Console.WriteLine("Dizinin elemanlarının ortalaması:{0}",toplam/sayac);
