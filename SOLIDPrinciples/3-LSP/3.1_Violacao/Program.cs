using SOLIDPrinciples._3_LSP._3._1_Violacao;
using System;

namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var ave = new Ave();
            Console.WriteLine("AVE: ");
            ave.Voar();

            Console.WriteLine();

            var aguia = new Aguia();
            Console.WriteLine("AGUIA: ");
            aguia.Voar();

            Console.WriteLine();

            var pombo = new Pombo();
            Console.WriteLine("POMBO: ");
            pombo.Voar();

            Console.WriteLine();

            var avestruz = new Avestruz();
            Console.WriteLine("AVESTRUZ: ");
            avestruz.Voar();

            Console.WriteLine();

            Ave ave1 = new Avestruz();
            Console.WriteLine("AVEstruz: ");
            ave1.Voar();


            
            Console.ReadKey();
        }
    }
}
