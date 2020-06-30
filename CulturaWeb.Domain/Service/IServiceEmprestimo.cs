using CulturaWeb.Domain.Entity;
using System;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceEmprestimo
    {
        void Emprestar(Emprestimo emprestimo);
        void Devolver(Emprestimo emprestimo);
    }
}
