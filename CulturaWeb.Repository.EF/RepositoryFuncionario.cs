using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Repository.EF
{
    public class RepositoryFuncionario : IRepositoryFuncionario
    {
        public RepositoryFuncionario(DCCulturaWeb contexto)
        {
        }

        public bool Cadastrar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int funcionarioId)
        {
            throw new NotImplementedException();
        }

        public bool Incluir(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterFuncionarioPorId(int funcionarioId)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterFuncionarioPorNome(string funcionarioNome)
        {
            throw new NotImplementedException();
        }

        public IList<Funcionario> ObterFuncionarioPorSetor(string funcionarioSetor)
        {
            throw new NotImplementedException();
        }

        public IList<Funcionario> ObterTodosFuncionarios()
        {
            throw new NotImplementedException();
        }
    }
}
