// See https://aka.ms/new-console-template for more informationc
System.Console.WriteLine("Lütfen bir sayı girin");
int sayac = int.Parse(Console.ReadLine());

System.Console.WriteLine("1 den girilen sayıya kadar olan tek sayılar:");
for (int i = 1; i < sayac; i++)
{
    if(i%2==1)
        System.Console.WriteLine(i);
}

System.Console.WriteLine("Girilen sayıya kadar olan tek ve cift sayıların toplamı:");

int tekToplam=0;
int ciftToplam=0;

for (int i = 0; i <= sayac; i++)
{
    if(i%2==0)
        ciftToplam+=i;
    else
        tekToplam+=i;

}
System.Console.WriteLine("Tek toplam:"+tekToplam);
    System.Console.WriteLine("Çift toplam"+ciftToplam);

System.Console.WriteLine("1 den 4 e kadar yazdır");
for (int i = 1; i < sayac; i++)
{
    if(i==4)
        break;
    System.Console.WriteLine(i);
}

System.Console.WriteLine("1 den sayaca kadar yaz 4 haric");
for (int i = 1; i < sayac; i++)
{
    if(i==4)
        continue;   
    System.Console.WriteLine(i); 
}