// See https://aka.ms/new-console-template for more information

int hour = DateTime.Now.Hour;

if(hour>=6 && hour<=11)
    System.Console.WriteLine("Gunaydin");
else if(hour>17)
    System.Console.WriteLine("İyi öğlenler");
else
    System.Console.WriteLine("İyi aksamlar");

string sonuc = hour>=6 && hour<=11 ? "Günaydın" : hour>17 ? "İyi öğlrenler" : "İyi Aksamlar";
System.Console.WriteLine(sonuc);