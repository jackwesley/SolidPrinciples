using SOLIDPrinciples._5_DIP._5._2_Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._5_DIP._5._2_Solucao
{
    public class EanService : IEanServices
    {
        public bool EhValido(string ean)
        {
            return ean.Length > 7;
        }
    }
}
