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
}

public class Surungerler:Hayvanlar
{
    public Surungerler()
    {
        base.Adaptasyon();
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
    }
    public void UcarakHareket()
    {
        System.Console.WriteLine("Kuslar ucarak hareket eder");
    }
}