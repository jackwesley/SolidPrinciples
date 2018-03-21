using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._5_DIP._5._1_Violacao
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string EAN { get; set; }
        public string UrlImagem { get; set; }
        public double Valor { get; set; }

        public bool EhValido()
        {
            return EanServices.EhValido(EAN) && ImagemServices.EhValido(UrlImagem);
        }
    }

    
}
