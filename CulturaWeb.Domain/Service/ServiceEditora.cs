using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public class ServiceEditora : IServiceEditora
    {
        private readonly IRepositoryEditora _repositoryEditora;
        public ServiceEditora(IRepositoryEditora repositoryEditora)
        {
            _repositoryEditora = repositoryEditora;
        }

        public bool Cadastrar(Editora editora)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Editora editora)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(Editora editora)
        {
            throw new NotImplementedException();
        }

        public Editora ObterEditoraPorId(int editorId)
        {
            throw new NotImplementedException();
        }

        public IList<Editora> ObterEditoras()
        {
            throw new NotImplementedException();
        }
    }
}
