using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CulturaWeb.Domain.Repository
{
    public interface IRepositoryLivro
    {
        Task Cadastrar(Livro livro);
        Task Editar(Livro livro);
        Task Excluir(Livro livro);
        Task<Livro> ObterLivroPorId(int livroId);
        Task<Livro> ObterLivroPorNome(string livroNome);
        Task<IList<Livro>> ObterLivroPorAutor(string livroAutor);
        Task<IList<Livro>> ObterLivroPorGenero(string livroGenero);
        Task<IList<Livro>> ObterTodosLivros();
    }
}
