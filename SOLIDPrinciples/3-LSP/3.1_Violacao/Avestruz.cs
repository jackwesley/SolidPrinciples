using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._3_LSP._3._1_Violacao
{
    public class Avestruz : Ave
    {
        //Classe filha infringindo no comportamento da classe mãe
        public override void Voar()
        {
            Console.WriteLine("Fui tentar voar, cai e quebrei as duas pernas!!");
        }
    }
}
