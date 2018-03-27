namespace SOLIDPrinciples._1_SRP._1._2_Solucao
{
    public static class ImagemServices
    {
        public static bool EhValido(string urlImagem)
        {
            return urlImagem.Contains("http://");
        }
    }
}