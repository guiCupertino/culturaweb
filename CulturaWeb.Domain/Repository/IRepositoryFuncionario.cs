using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Repository
{
    public interface IRepositoryFuncionario
    {
        bool Cadastrar(Funcionario funcionario);
        bool Editar(Funcionario funcionario);
        bool Incluir(Funcionario funcionario);
        bool Excluir(int funcionarioId);
        Funcionario ObterFuncionarioPorId(int funcionarioId);
        Funcionario ObterFuncionarioPorNome(string funcionarioNome);
        IList<Funcionario> ObterFuncionarioPorSetor(string funcionarioSetor);
        IList<Funcionario> ObterTodosFuncionarios();
    }
}
