using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorTelefone : AbstractValidator<Telefone>
    {
        public ValidadorTelefone()
        {
            RuleFor(p => p.DDD).NotEmpty().WithMessage("O DDD é obrigatório.")
                                          .Length(2).WithMessage("O DDD deve ter 2 dígitos.");

            RuleFor(p => p.NumeroTelefone).NotEmpty().WithMessage("O telefone é obrigatório.")
                                        .Length(8, 9).WithMessage("O telefone deve ter no mínimo 8 e no máximo 9 dígitos.");
        }        
    }
}
