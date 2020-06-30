using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorSetor : AbstractValidator<Setor>
    {
        public ValidadorSetor()
        {
            RuleFor(p => p.Nome).NotEmpty()
                .WithMessage("Setor obrigatório para funcionario");

        }
    }
}
