using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorGenero : AbstractValidator<Genero>
    {
        public ValidadorGenero()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("Genero obrigatório");
        }
    }
}
