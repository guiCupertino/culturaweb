using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public class ServiceGenero : IServiceGenero
    {
        private readonly IRepositoryGenero _repositoryGenero;

        public ServiceGenero(IRepositoryGenero repositoryGenero)
        {
            _repositoryGenero = repositoryGenero;
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
