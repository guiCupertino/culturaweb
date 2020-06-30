using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorItemEmprestimo : AbstractValidator<ItemEmprestimo>
    {
        public ValidadorItemEmprestimo()
        {
            RuleFor(p => p.Livro).SetValidator(new ValidadorLivro());
        }
    }
}
