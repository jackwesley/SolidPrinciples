namespace SOLIDPrinciples._1_SRP._1._2_Solucao
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