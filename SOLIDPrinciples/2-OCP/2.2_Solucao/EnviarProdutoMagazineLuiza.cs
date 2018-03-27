using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._2_Solucao
{
    public class EnviarProdutoMagazineLuiza : EnviaMarketplace
    {
        public override string Enviar(int produtoId, int businessId)
        {
            
            //Logiga de envio para Magazine Luiza

            return RegistroTransacao;
        }
    }
}
