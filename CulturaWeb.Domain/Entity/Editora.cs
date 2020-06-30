using CulturaWeb.Domain.Validation;

namespace CulturaWeb.Domain.Entity
{
    public class Editora : Entity
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
