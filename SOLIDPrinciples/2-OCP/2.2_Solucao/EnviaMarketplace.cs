namespace SOLIDPrinciples._2_OCP._2._2_Solucao
{
    
    public abstract class EnviaMarketplace
    {
        public string RegistroTransacao { get; set; }

        //Método abstrato para ser obrigado a fazer o override nos herdeiros
        public abstract string Enviar(int produtoId, int businessId); 
    }
}
