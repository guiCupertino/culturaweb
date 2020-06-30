using CulturaWeb.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorAluno : AbstractValidator<Aluno>
    {
        public ValidadorAluno()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O nome é obrigatório.")
                               .Length(3, 100).WithMessage("O nome deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.Email).NotEmpty().WithMessage("O e-mail é obrigatório.")
                                 .EmailAddress().WithMessage("E-mail inválido.")
                                 .Length(3, 100).WithMessage("O e-mail deve ter no mínimo 3 e no máximo 100 caracteres.");

            RuleFor(p => p.DataDeNascimento).NotEmpty().WithMessage("A data de nascimento é obrigatória.");

            RuleFor(p => p.Endereco).SetValidator(new ValidadorEndereco());

            RuleFor(p => p.Telefone).SetValidator(new ValidadorTelefone());
        }
    }
}
