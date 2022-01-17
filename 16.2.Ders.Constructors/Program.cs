// See https://aka.ms/new-console-template for more information

Calisan calisan = new Calisan("Gözde","Cengiz",1234567,"Yazılım");
/*
calisan.Ad = "Gözde";
calisan.Soyad = "Cengiz";
calisan.No = 1234567;
calisan.Departman="Yazılım";
*/
calisan.CalisanBilgileri();

System.Console.WriteLine("******");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Ahmet";
calisan2.Soyad = "Simsir";
calisan2.No = 7654321;
calisan2.Departman="İnşaat";
calisan2.CalisanBilgileri();

System.Console.WriteLine("*******");
Calisan calisan3 = new Calisan("Simge","Cengiz");
calisan3.CalisanBilgileri();

public class Calisan{
    public string Ad { get; set; }
    public string Soyad { get; set; }   
    public int No { get; set; }    
    public string Departman { get; set; } 

    public Calisan(string ad, string soyad,int no,string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan(){}

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public void CalisanBilgileri()
    {
        System.Console.WriteLine("Calısan adı: {0}",Ad);
        System.Console.WriteLine("Calısan soyad: {0}",Soyad);
        System.Console.WriteLine("Calısan no: {0}",No);
        System.Console.WriteLine("Calısan departman: {0}",Departman);
    }
}
