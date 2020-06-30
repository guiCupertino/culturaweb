using CulturaWeb.Domain.Validation;

namespace CulturaWeb.Domain.Entity
{
    public class Cidade : Entity
    {
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
