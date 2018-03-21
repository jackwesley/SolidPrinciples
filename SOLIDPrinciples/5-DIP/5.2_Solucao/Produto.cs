using SOLIDPrinciples._5_DIP._5._2_Solucao.Interfaces;


namespace SOLIDPrinciples._5_DIP._5._2_Solucao
{
    public class Produto
    {
        private readonly IEanServices _eanServices;
        private readonly IImagemServices _imagemServices;

        public Produto(IEanServices eanServices, IImagemServices imagemServices)
        {
            _eanServices = eanServices;
            _imagemServices = imagemServices;
        }

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string EAN { get; set; }
        public string UrlImagem { get; set; }
        public double Valor { get; set; }

        public bool EhValido()
        {
            return _eanServices.EhValido(EAN) && _imagemServices.EhValido(UrlImagem);
        }
    }


}
