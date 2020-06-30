using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceFuncionario
    {
        bool Cadastrar(Funcionario funcionario);
        bool Editar(Funcionario funcionario);
        bool Incluir(Funcionario funcionario);
        bool Excluir(int funcionarioId);
        Funcionario ObterFuncionarioPorId(int funcionarioId);
        IList<Funcionario> ObterFuncionarioPorSetor(string setor);
        IList<Funcionario> ObterTodosFuncionarios();
    }
}
