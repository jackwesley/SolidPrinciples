using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._4_ISP._4._1_Violacao
{
    public interface IMarketplace
    {
        void EnviaProduto();

        void EnviaEstoque();

        void EnviaPreco();

        void EnviaUrlDeVideo();

        void EnviaCrossDocking();
    }
}
