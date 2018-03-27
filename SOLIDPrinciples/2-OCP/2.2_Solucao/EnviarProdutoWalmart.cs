using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._2_Solucao
{
    class EnviarProdutoWalmart : EnviaMarketplace
    {
        public override string Enviar(int produtoId, int businessId)
        {
            //Logica de envio para Walmart

            return RegistroTransacao;
        }
    }
}
