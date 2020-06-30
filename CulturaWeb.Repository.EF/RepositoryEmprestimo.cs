using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using System;

namespace CulturaWeb.Repository.EF
{
    public class RepositoryEmprestimo : IRepositoryEmprestimo
    {
        public RepositoryEmprestimo(DCCulturaWeb contexto)
        {
        }

        public void Devolver(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public void Emprestar(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }
    }
}
