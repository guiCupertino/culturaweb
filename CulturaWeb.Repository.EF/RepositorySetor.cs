using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Repository.EF
{
    public class RepositorySetor : IRepositorySetor
    {

        public RepositorySetor(DCCulturaWeb contexto)
        {
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
