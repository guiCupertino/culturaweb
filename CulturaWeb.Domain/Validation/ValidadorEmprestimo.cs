using CulturaWeb.Domain.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Validation
{
    public class ValidadorEmprestimo : AbstractValidator<Emprestimo>
    {
        public ValidadorEmprestimo()
        {
            RuleFor(p => p.Aluno).SetValidator(new ValidadorAluno());
            RuleFor(p => p.Funcionario).SetValidator(new ValidadorFuncionario());            
        }
    }
}
