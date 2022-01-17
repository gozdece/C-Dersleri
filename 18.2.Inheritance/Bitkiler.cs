public class Bitkiler:Canlilar
{
    public Bitkiler()
    {
        base.Bosaltim();
        base.Beslenme();
        base.Solunum();
    }
    protected void Fotosentez()
    {
        System.Console.WriteLine("Bitkiler fotosentez yapar");
    }
}

public class TohumluBitkiler:Bitkiler
{
    public TohumluBitkiler(){
        base.Fotosentez();
    }
    public void TohumlaCogalma()
    {
        System.Console.WriteLine("Thoumlu bitkiler tohumla cogalir.");
    }
    
}
public class TohumsuzBitkiler:Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.Fotosentez();
    }
    public void SpoarlaCogalma()
    {
        System.Console.WriteLine("Tohumsuz bitkiler sporla cogalir");
    }
}