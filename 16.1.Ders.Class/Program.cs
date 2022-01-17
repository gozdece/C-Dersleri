// See https://aka.ms/new-console-template for more information

Calisan calisan = new Calisan();
calisan.Ad = "Gözde";
calisan.Soyad = "Cengiz";
calisan.No = 1234567;
calisan.Departman="Yazılım";
calisan.CalisanBilgileri();

System.Console.WriteLine("******");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Ahmet";
calisan2.Soyad = "Simsir";
calisan2.No = 7654321;
calisan2.Departman="İnşaat";
calisan2.CalisanBilgileri();


public class Calisan{
    public string Ad { get; set; }
    public string Soyad { get; set; }   
    public int No { get; set; }    
    public string Departman { get; set; } 
    public void CalisanBilgileri()
    {
        System.Console.WriteLine("Calısan adı: {0}",Ad);
        System.Console.WriteLine("Calısan soyad: {0}",Soyad);
        System.Console.WriteLine("Calısan no: {0}",No);
        System.Console.WriteLine("Calısan departman: {0}",Departman);
    }
}