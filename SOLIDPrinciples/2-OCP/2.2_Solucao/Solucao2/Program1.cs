using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao.Solucao2
{
    public class Program1
    {
        static void Main1(string[] args)
        {
            var assinatura = new Assinatura();
            var aluno = new Aluno("Jack", "Moreira", "112325465", "eu@mail.com");
            // aluno.Assinaturas.Add(assinatura);
            aluno.AdicionarAssinatura(assinatura);


            Console.ReadKey();
        }
    }
}
