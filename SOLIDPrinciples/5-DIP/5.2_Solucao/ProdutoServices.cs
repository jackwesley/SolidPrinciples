using SOLIDPrinciples._5_DIP._5._2_Solucao.Interfaces;

namespace SOLIDPrinciples._5_DIP._5._2_Solucao
{
    public class ProdutoServices : IProdutoServices
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IFilaServices _filaServices;

        public ProdutoServices(IProdutoRepository produtoRepository, IFilaServices filaServices)
        {
            _produtoRepository = produtoRepository;
            _filaServices = filaServices;
        }

        public string AdicionarProduto(Produto produto)
        {
            if (!produto.EhValido())
                return "Produto com dados inválidos";

            
            _produtoRepository.AdicionarProduto(produto);


            _filaServices.InserirProdutoNaFila(produto);

            return "Produto Cadastrado com sucesso";
        }
    }
}
