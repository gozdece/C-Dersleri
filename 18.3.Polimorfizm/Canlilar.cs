public class Canlilar
{
    protected void Solunum()
    {
        System.Console.WriteLine("Butun hayvanlar solunum yapar.");
    }
    protected void Bosaltim()
    {
        System.Console.WriteLine("Butun hayvanlar bosaltim yapar.");
    }
    protected void Beslenme()
    {
        System.Console.WriteLine("Butun hayvanlar beslenir");
    }
    public virtual void Tepki()
    {
        System.Console.WriteLine("Butun hayvanlar tepki verir");
    }
}