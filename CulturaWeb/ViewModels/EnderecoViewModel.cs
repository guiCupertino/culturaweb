namespace CulturaWeb.Api.ViewModels
{
    public class EnderecoViewModel
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public CidadeViewModel Cidade { get; set; }
    }
}