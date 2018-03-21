namespace SOLIDPrinciples._5_DIP._5._1_Violacao
{
    public static class EanServices
    {
        public static bool EhValido(string ean)
        {
            return ean.Length > 7;
        }
    }
}