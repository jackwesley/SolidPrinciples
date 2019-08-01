using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._2_OCP._2._1_Violacao.Violacao2
{
    public class Program1
    {
        static void Main1(string[] args)
        {
            var assinatura = new Assinatura();
            var aluno = new Aluno("Jack", "Moreira", "112325465", "eu@mail.com");
            aluno.Assinaturas.Add(assinatura);


            //não cancela a assinatura e adiciona uma nova, pois não passa no método da classe de serviço
            //que tem regra de negocio


            Console.ReadKey();
        }
    }
}
