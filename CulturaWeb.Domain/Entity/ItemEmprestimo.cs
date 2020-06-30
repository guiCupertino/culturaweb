using CulturaWeb.Domain.Validation;

namespace CulturaWeb.Domain.Entity
{
    public class ItemEmprestimo: Entity
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }
        public int EmprestimoId { get; set; }
        public Emprestimo Emprestimo { get; set; }
    }
}
