using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._4_ISP._4._2_Solucao
{
    public interface IMarketplaceCNova
    {
        void EnviaProduto();

        void EnviaEstoque();

        void EnviaPreco();

        void EnviaCrossDocking();
    }
}
