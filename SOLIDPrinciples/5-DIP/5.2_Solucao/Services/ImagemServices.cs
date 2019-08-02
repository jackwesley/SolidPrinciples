using SOLIDPrinciples._5_DIP._5._2_Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._5_DIP._5._2_Solucao
{
    public class ImagemServices : IImagemServices
    {
        public bool EhValido(string urlImagem)
        {
            return urlImagem.Contains("http://");
        }

        public string ArrumarImagem(string urlImagem)
        {
            if (!urlImagem.Contains("http://"))
                return string.Format("http://{0}", urlImagem);
            else
                return urlImagem;
        }
    }
}
