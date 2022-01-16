// See https://aka.ms/new-console-template for more information

Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim="Gözde";
ogrenci.Soyisim="Cengiz";
ogrenci.Sinif=2;
ogrenci.OgrenciNo=123;
ogrenci.OgrenciBilgileriniGetir();
System.Console.WriteLine("****");
Ogrenci ogrenci1 = new Ogrenci("Simge","Cengiz",123,1);
ogrenci1.OgrenciBilgileriniGetir();
ogrenci1.SinifDusur();
ogrenci1.OgrenciBilgileriniGetir();
public class Ogrenci
{
    private string isim;
    private string  soyisim;
    private int ogrenciNo;
    private int sinif;
    public string Isim 
    {   get {return isim;} 
        set {isim = value;} 
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { get => sinif; 
    set
    { 
        if(value <1)
        {
            System.Console.WriteLine("Sınıf en az 1 olabilir");
            sinif =1;
        }else{
            sinif = value;
        }
    }
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        this.isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci(){}
    public void OgrenciBilgileriniGetir()
    {
        System.Console.WriteLine("Ogrenci adı: {0}",this.Isim);
         System.Console.WriteLine("Ogrenci soyadı: {0}",this.Soyisim);
          System.Console.WriteLine("Ogrenci numarası: {0}",this.OgrenciNo);
           System.Console.WriteLine("Ogrenci sınıfı: {0}",this.Sinif);
    }
    public void SinifAtlat()
    {
        this.Sinif = this.Sinif+1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif-1;
    }
}
