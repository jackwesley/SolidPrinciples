using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._3_LSP._3._1_Violacao
{
    public class Pombo : Ave
    {
        public override void Voar()
        {
            Console.WriteLine("PRUUUU... Voando e procurando alvo para dar uma carimbada.");
        }
    }
}
