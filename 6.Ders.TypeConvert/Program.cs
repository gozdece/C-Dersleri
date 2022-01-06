// See https://aka.ms/new-console-template for more information

//Implicit Conversion (Bilinçsiz Dönüşüm)

byte a =5;
sbyte b=30;
short c= 4;

int d=a+b+c;
long h =d;
float i = h;

//En az kapsamlı olan diğer türe dönüşür

string isim ="Gözde";
char f='a';
object g= isim+f;

//Explicit Conversion (Bilinçli Dönüşüm)
int x = 4;
byte y=(byte)x; //int byte dönüşür

//ToString metodu
int z =6;
string zz = z.ToString();
string ab = 12.5f.ToString();

//System.Convert
string s1="10";
string s2="20";
int toplam = Convert.ToInt32(s1)+Convert.ToInt32(s2);

//Parse
ParseMethod();

 static void ParseMethod()
{
    string metin ="10";
    string metin2="10.25";
    int rakam1;
    double double1;

    rakam1 = Int32.Parse(metin);
    double1 =Int32.Parse(metin2);
    
}