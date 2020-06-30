using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Domain.Service
{
    public class ServiceSetor : IServiceSetor
    {
        private readonly IRepositorySetor _repositorySetor;

        public ServiceSetor(IRepositorySetor repositorySetor)
        {
            _repositorySetor = repositorySetor;
        }

        public bool Cadastrar(Setor setor)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Setor setor)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int setorId)
        {
            throw new NotImplementedException();
        }

        public Setor ObterSetorPorId(int setorId)
        {
            throw new NotImplementedException();
        }

        public IList<Setor> ObterTodosSetores()
        {
            throw new NotImplementedException();
        }
    }
}
