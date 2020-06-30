using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using System;
using System.Collections.Generic;

namespace CulturaWeb.Repository.EF
{
    public class RepositoryEditora : IRepositoryEditora
    {
        public RepositoryEditora(DCCulturaWeb contexto)
        {
        }

        public bool Cadastrar(Editora editora)
        {
            throw new NotImplementedException();
        }

        public bool Editar(Editora editora)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int editoraId)
        {
            throw new NotImplementedException();
        }

        public Editora ObterEditoraPorId(int editoraId)
        {
            throw new NotImplementedException();
        }

        public Editora ObterEditoraPorNome(string editoraNome)
        {
            throw new NotImplementedException();
        }

        public IList<Editora> ObterTodasEditoras()
        {
            throw new NotImplementedException();
        }
    }
}
