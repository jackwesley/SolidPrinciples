﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._4_ISP._4._1_Violacao
{
    public class CNova : IMarketplace
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

        public void EnviaUrlDeVideo()
        {
            //Marketplace não recebe url de video do produto, o que faço??
            throw new NotImplementedException();
        }

        public void EnviaCrossDocking()
        {
            //Logica de envio de prazo cross docking 
        }
    }
}
