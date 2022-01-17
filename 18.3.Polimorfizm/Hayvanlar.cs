public class Hayvanlar: Canlilar
{
    public Hayvanlar()
    {
        base.Beslenme();
        base.Bosaltim();
        base.Solunum();
    }
    protected void Adaptasyon()
    {
        System.Console.WriteLine("hayvanlar adaptosyon yapar");
    }
    public override void Tepki()
    {
        base.Tepki();
        System.Console.WriteLine("Hayvanlar temasa tepki verir");
    }
}

public class Surungerler:Hayvanlar
{
    public Surungerler()
    {
        base.Adaptasyon();
        base.Tepki();
    }
    public void SurunerekHareket()
    {
        System.Console.WriteLine("Surungenler surunerek hareket ederler");
    }
}
public class Kuslar:Hayvanlar
{
    public Kuslar()
    {
        base.Adaptasyon();
        base.Tepki();
    }
    public void UcarakHareket()
    {
        System.Console.WriteLine("Kuslar ucarak hareket eder");
    }
}