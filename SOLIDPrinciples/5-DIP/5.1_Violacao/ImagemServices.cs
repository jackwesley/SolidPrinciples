namespace SOLIDPrinciples._5_DIP._5._1_Violacao
{
    public static class ImagemServices
    {
        public static bool EhValido(string urlImagem)
        {
            return urlImagem.Contains("http://");
        }



        public static string ArrumarImagem(string urlImagem)
        {
            if (!urlImagem.Contains("http://"))
                return string.Format("http://{0}", urlImagem);
            else
                return urlImagem;
        }
    }
}