using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao.Violacao2
{
    public class Aluno
    {
        public Aluno(string nome, string sobrenome, string documento, string email)
        {
            Nome = nome;
            SobreNome = sobrenome;
            Documento = documento;
            Email = email;


        }

        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; private set; }
        public List<Assinatura> Assinaturas { get; private set; }

        public void AdicionarAssinatura(Assinatura assinatura)
        {

            //Cancela todas as outras e coloca esta como principal
            foreach (var ass in Assinaturas)
            {
                ass.Inativar();
            }

            Assinaturas.Add(assinatura);
        }
    }
}
