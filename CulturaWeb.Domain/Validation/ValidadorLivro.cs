using CulturaWeb.Domain.Entity;
using FluentValidation;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorLivro : AbstractValidator<Livro>
    {
        public ValidadorLivro()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O nome é obrigatório.")
                                .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.Titulo).NotEmpty().WithMessage("O título é obrigatório.");

            RuleFor(p => p.Autor).NotEmpty().WithMessage("O autor do livro é obrigatório");

            RuleFor(p => p.Descricao).NotEmpty().WithMessage("Descrição obrigatória");

            //RuleFor(p => p.Genero).SetCollectionValidator(new ValidadorGenero());

        }
    }
}
