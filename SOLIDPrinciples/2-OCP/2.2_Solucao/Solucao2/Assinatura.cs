using System;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao.Solucao2
{
    public class Assinatura
    {

        public DateTime DataCriacao { get;  set; }
        public DateTime UltimaAtualizacao { get;  set; }
        public DateTime DataExpiracao { get;  set; }
        public bool Ativa { get; set; }


    }
}