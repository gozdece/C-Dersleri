// See https://aka.ms/new-console-template for more information

/*
try
{
     System.Console.WriteLine("Bir değer girin:");
     int rakam = Convert.ToInt32(Console.ReadLine());
     System.Console.WriteLine("Girdiğiniz değer:" + rakam);
}
catch (System.Exception ex)
{
    System.Console.WriteLine("Hata:"+ex.Message);
}finally{
    System.Console.WriteLine("Finally");
}

try
{
     int rakam = int.Parse(null);
}
catch (System.ArgumentException ex)
{
    System.Console.WriteLine("Boş bir değer girdiniz");
    System.Console.WriteLine("Hata:"+ex.Message);
}
*/
try
{   
    System.Console.WriteLine("Bir sayı girin:");
    int rakam = Convert.ToInt32(Console.ReadLine());
}
catch (System.OverflowException ex)
{
    System.Console.WriteLine("Geçersiz aralıkta");
    System.Console.WriteLine("Hata:"+ex.Message);
}