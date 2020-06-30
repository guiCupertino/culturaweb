using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorEditora : AbstractValidator<Editora>
    {
        public ValidadorEditora()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("Nome da editor é obrigatório");

            RuleFor(p => p.Endereco).SetValidator(new ValidadorEndereco());
        }
    }
}
