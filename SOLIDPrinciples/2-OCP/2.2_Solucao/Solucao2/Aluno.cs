using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao.Solucao2
{
    public class Aluno
    {
        private IList<Assinatura> _assinaturas;

        public Aluno(string nome, string sobrenome, string documento, string email)
        {
            Nome = nome;
            SobreNome = sobrenome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();

        }

        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }

        public void AdicionarAssinatura(Assinatura assinatura)
        {

            //Cancela todas as outras e coloca esta como principal
            foreach (var ass in Assinaturas)
            {
                ass.Ativa = false;
            }

            _assinaturas.Add(assinatura);
        }

    }
}
