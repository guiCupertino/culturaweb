using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorEstado : AbstractValidator<Estado>
    {
        public ValidadorEstado()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O nome é obrigatório.")
                                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.UF).NotEmpty().WithMessage("A UF é obrigatória.")
                              .Length(2).WithMessage("A UF deve ter no 2 caracteres.");
        }
    }
}
