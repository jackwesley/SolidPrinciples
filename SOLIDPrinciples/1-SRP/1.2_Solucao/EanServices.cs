namespace SOLIDPrinciples._1_SRP._1._2_Solucao
{
    public static class EanServices
    {
        public static bool EhValido(string ean)
        {
            return ean.Length > 7;
        }
    }
}