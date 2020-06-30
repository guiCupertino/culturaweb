using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Repository.EF
{
    public class RepositoryGenero : IRepositoryGenero
    {
        public RepositoryGenero(DCCulturaWeb contexto)
        {
        }

        public bool Cadastrar(Genero genero)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Genero genero)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int generoId)
        {
            throw new NotImplementedException();
        }

        public Genero ObterGeneroPorId(int generoId)
        {
            throw new NotImplementedException();
        }

        public IList<Genero> ObterTodosGeneros()
        {
            throw new NotImplementedException();
        }
    }
}
