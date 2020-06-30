using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorEndereco : AbstractValidator<Endereco>
    {
        public ValidadorEndereco()
        {
            RuleFor(p => p.Logradouro).Length(3, 100).When(p => !string.IsNullOrEmpty(p.Logradouro))
                                                     .WithMessage("O logradouro deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.Numero).NotEmpty().WithMessage("Número é obrigatório.");

            RuleFor(p => p.CEP).Length(8).When(p => !string.IsNullOrEmpty(p.CEP)).WithMessage("CEP inválido.");

            RuleFor(p => p.Bairro).Length(3, 100).When(p => !string.IsNullOrEmpty(p.Bairro)).WithMessage("O logradouro deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.CidadeId).NotEmpty().WithMessage("A cidade é obrigatória.");
        }
    }
}
