﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._4_ISP._4._1_Violacao
{
    public class Walmart : IMarketplace
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
           //logida de envio de url de vídeo
        }

        public void EnviaCrossDocking()
        {
            throw new NotImplementedException();
        }

       
    }
}
