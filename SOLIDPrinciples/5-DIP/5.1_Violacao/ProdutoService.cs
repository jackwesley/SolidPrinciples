using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples._5_DIP._5._1_Violacao
{
    public class ProdutoService
    {
        public string AdicionarProduto(Produto produto)
        {
            if (!produto.EhValido())
                return "Produto com dados inválidos";

            var repository = new ProdutoRepository();
            repository.AdicionarProduto(produto);


            var fila = new FilaProduto();
            fila.Inserir(produto);

            return "Produto Cadastrado com sucesso";
        }
    }
}
