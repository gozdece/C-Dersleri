using System;

namespace _18._3.Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            System.Console.WriteLine("****");
            
            Kuslar marti = new Kuslar();
            marti.UcarakHareket();
        }
    }
}
