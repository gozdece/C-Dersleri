// See https://aka.ms/new-console-template for more information

int[] dizi = {1,7,23,4,18,86,42};

System.Console.WriteLine("Sırasız dizi");
foreach (var item in dizi)
{
    System.Console.Write(item+"-");
}
System.Console.WriteLine();
System.Console.WriteLine("Sıralı dizi");
Array.Sort(dizi);
foreach (var item in dizi)
{
    System.Console.Write(item+"-");
}

//Clear
System.Console.WriteLine("Clear methodu");
System.Console.WriteLine("2.elemandan başlayarak 3 elamanı sıfırlayacak");
Array.Clear(dizi,2,3);
foreach (var item in dizi)
{
    System.Console.Write(item+"-");
}

//Reverse
System.Console.WriteLine("Array Reverse");
System.Console.WriteLine("Elemanlar tersten sıralanacak");
Array.Reverse(dizi);
foreach (var item in dizi)
{
    System.Console.Write(item+"-");
}

System.Console.WriteLine();

//Array IndexOF
System.Console.WriteLine("Array Indexof");
System.Console.WriteLine("42 numaralı elemanın index değerini dönecek");
System.Console.WriteLine(Array.IndexOf(dizi,42));

//Resize
System.Console.WriteLine("Array Resize");
System.Console.WriteLine("7 elemanlı diziyi 8 elamanlı yapacağız ve sonuna 10 değerini ekleyeceğiz");
Array.Resize<int>(ref dizi,8);
dizi[7]=10;
foreach (var item in dizi)
{
    System.Console.Write(item+"-");
}