using CulturaWeb.Domain.Validation;

namespace CulturaWeb.Domain.Entity
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }        
    }
}
