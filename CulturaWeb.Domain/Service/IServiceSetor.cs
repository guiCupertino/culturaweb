using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceSetor
    {
        bool Cadastrar(Setor setor);
        bool Editar(Setor setor);
        bool Excluir(int setorId);
        IList<Setor> ObterTodosSetores();
        Setor ObterSetorPorId(int setorId);
    }
}
