using SOLIDPrinciples._3_LSP._2._1_Violacao;
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

            var aguia = new Aguia();
            Console.WriteLine("AGUIA: ");
            aguia.Voar();

            var avestruz = new Avestruz();
            Console.WriteLine("AVESTRUZ: ");
            avestruz.Voar();


            Ave ave1 = new Avestruz();
            Console.WriteLine("AVEstruz: ");
            ave1.Voar();




            Console.ReadKey();
        }
    }
}
