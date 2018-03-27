using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._2_Solucao
{
    public class EnviarProdutoB2W : EnviaMarketplace
    {
        public override string Enviar(int produtoId, int businessId)
        {
            //Logica de envio para Walmart

            return RegistroTransacao;
        }
    }
}
