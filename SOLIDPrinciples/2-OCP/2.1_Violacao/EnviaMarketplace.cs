
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao
{
    public class EnviaMarketplace
    {
        public void Enviar(int produtoId, int businessId, Marketplace mkp)
        {
            if(mkp == Marketplace.MagazineLuiza)
            {
                //Logica de envio para Magazine Luiza
            }

            if (mkp == Marketplace.Walmart)
            {
                //Logica de envio para Walmart
            }
        }
    }
}
