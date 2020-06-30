using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public class ServiceEmprestimo : IServiceEmprestimo
    {
        private readonly IRepositoryEmprestimo _repositoryEmprestimo;
        public ServiceEmprestimo(IRepositoryEmprestimo repositoryEmprestimo)
        {
            _repositoryEmprestimo = repositoryEmprestimo;
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
