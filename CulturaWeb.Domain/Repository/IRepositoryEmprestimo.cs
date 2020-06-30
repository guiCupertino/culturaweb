using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Repository
{
    public interface IRepositoryEmprestimo
    {
        void Emprestar(Emprestimo emprestimo);
        void Devolver(Emprestimo emprestimo);        
    }
}
