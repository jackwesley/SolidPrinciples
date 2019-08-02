using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._4_ISP._4._2_Solucao
{
    public class Magalu : IMarketplaceCNova
    {
        public void EnviaProduto()
        {
            //Logica de envio de produto
        }

        public void EnviaEstoque()
        {
            //Logica de envio de Estoque
        }

        public void EnviaPreco()
        {
            //Logica de envio de Preço
        }

        public void EnviaCrossDocking()
        {
            //Logica de envio de prazo cross docking 
        }
    }
}
