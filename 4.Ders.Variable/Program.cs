// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# Veri Tipleri");

byte b = 5;
sbyte c=5;

short s=5;
ushort us=5;

Int16 i16= 2;
int i =2;
Int32 i32 =2;
Int64 i64 =2;

uint ui=2;
long l=4;
ulond ul=4;

float f=5;
double d=5;
decimal de =5;

char ch='a';
string str="Gözde";

bool b1 = true;
bool b2= false;

DateTime dt =DateTime.Now;

object o1= "x";
object o2='y';
object o3 = 4;
object o4=4.3;

//Degisken Dönüşümleri
string str20 ="20";
int int20 = 20;

string yeniDeger = str20 + int20.ToString();
//yeniDeger = 2020

int int21 = int20 + Convert.ToInt32(str20);
//int21 = 40 

int22 = int20 + int.Parse(str20); //cıktısı 40

//datetime
string datetime = datetime.Now.ToString("dd.MM.yyyy");


