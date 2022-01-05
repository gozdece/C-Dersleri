// See https://aka.ms/new-console-template for more information


//ATAMA ve İŞLEMLİ ATAMA
int x=5;
int y=6;
y +=2;
Console.WriteLine(y);
x*=3;
Console.WriteLine(x);

//Mantıksal 
// ||, &&, !
bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)
System.Console.WriteLine("Perfect");

if(isSuccess || isCompleted)
System.Console.WriteLine("Great");

if(isSuccess && !isCompleted)
System.Console.WriteLine("Fine");

//İlişkisel Operatörler
//< > <= >= == !=

int a =3;
int b=4;
bool sonuc =a<b;

System.Console.WriteLine(sonuc);
sonuc= a>b;
System.Console.WriteLine(sonuc);



