using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Repository
{
    public interface IRepositoryEditora
    {
        bool Cadastrar(Editora editora);
        bool Editar(Editora editora);
        bool Excluir(int editoraId);
        Editora ObterEditoraPorId(int editoraId);
        Editora ObterEditoraPorNome(string editoraNome);
        IList<Editora> ObterTodasEditoras();
    }
}
