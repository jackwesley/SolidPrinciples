﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._3_LSP._3._1_Violacao
{
    public class Aguia : Ave
    {
        public override void Voar()
        {
            Console.WriteLine("Voando ao infinito e além");
        }
    }
}
