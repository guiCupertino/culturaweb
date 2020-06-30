using CulturaWeb.Domain.Validation;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Domain.Entity
{
    public class Emprestimo : Entity
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }        
        public IList<ItemEmprestimo> ItemEmprestimos { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }

        public DateTime DataDeLocacao() => this.DataLocacao;

        public DateTime DataDeDevolucao() => this.DataDevolucao;

    }
}
