using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public class ServiceFuncionario : IServiceFuncionario
    {
        private readonly IRepositoryFuncionario _repositoryFuncionario;

        public ServiceFuncionario(IRepositoryFuncionario repositoryFuncionario)
        {
            _repositoryFuncionario = repositoryFuncionario;
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

        public IList<Funcionario> ObterFuncionarioPorSetor(string setor)
        {
            throw new NotImplementedException();
        }

        public IList<Funcionario> ObterTodosFuncionarios()
        {
            throw new NotImplementedException();
        }
    }
}
