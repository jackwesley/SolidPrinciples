using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._1_SRP._1._1_Violacao
{
    public class FilaProduto
    {
        public void Inserir(ProdutoParaFila produto)
        {
            //Codigo para inserir na fila
        }
    }

    public class ProdutoParaFila
    {
        public int ProdutoId { get; set; }
        public int Marketplace { get; set; }
        public DateTime DataInsercao { get; set; }
    }
}
