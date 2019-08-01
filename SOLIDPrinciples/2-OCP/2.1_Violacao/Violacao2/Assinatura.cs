using System;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao.Violacao2
{
    public class Assinatura
    {


        public Assinatura()
        {
            DataCriacao = DateTime.Now;
            UltimaAtualizacao = DateTime.Now;
            DataExpiracao = DateTime.Now.AddDays(30);
            Ativa = true;
        }

        public DateTime DataCriacao { get;  private set; }
        public DateTime UltimaAtualizacao { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public bool Ativa { get; private set; }


        public void Inativar()
        {
            Ativa = false;
            UltimaAtualizacao = DateTime.Now;

        }
    }
}