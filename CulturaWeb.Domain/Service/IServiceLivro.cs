using CulturaWeb.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceLivro
    {
        Task<bool> Cadastrar(Livro livro);
        Task<bool> Editar(Livro livro);
        Task<bool> Excluir(int livroId);
        Task<IList<Livro>> ObterTodosLivros();
        Task<IList<Livro>> ObterLivrosPorGenero(string genero);
        Task<IList<Livro>> ObterLivrosPorAutor(string auto);
        Task<Livro> ObterLivroPorId(int livroId);
    }
}
