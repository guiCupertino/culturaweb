using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorCidade : AbstractValidator<Cidade>
    {
        public ValidadorCidade()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O nome é obrigatório.")
                                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.EstadoId).NotEmpty().WithMessage("O estado é obrigatório.");
        }
    }
}
