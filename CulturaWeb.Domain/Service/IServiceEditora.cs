using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceEditora
    {
        bool Cadastrar(Editora editora);
        bool Editar(Editora editora);
        bool Excluir(Editora editora);
        IList<Editora> ObterEditoras();
        Editora ObterEditoraPorId(int editorId);
    }
}
