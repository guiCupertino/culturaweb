using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Repository.EF.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulturaWeb.Repository.EF
{
    public class RepositoryLivro : IRepositoryLivro
    {
        private readonly DCCulturaWeb _contexto;
        public RepositoryLivro(DCCulturaWeb contexto)
        {
            _contexto = contexto;
        }

        public async Task Cadastrar(Livro livro)
        {
            await _contexto.Livros.AddAsync(livro);
            _contexto.SaveChanges();
        }

        public async Task Editar(Livro livro)
        {
            _contexto.Livros.Update(livro);
            await _contexto.SaveChangesAsync();            
        }

        public async Task Excluir(Livro livro)
        {
            _contexto.Remove(livro);
            _contexto.SaveChanges();
        }

        public async Task<IList<Livro>> ObterLivroPorAutor(string livroAutor)
        {
            return await _contexto.Livros
                .AsNoTracking()
                .Include(i => i.Genero)
                .Include(i => i.Editora)
                .ThenInclude(i => i.Endereco)
                .ThenInclude(i => i.Cidade)
                .ThenInclude(i => i.Estado)
                .Where(l => l.Autor.Contains(livroAutor))
                .ToListAsync();
        }

        public async Task<IList<Livro>> ObterLivroPorGenero(string livroGenero)
        {
            return await _contexto.Livros
                .Include(i => i.Genero)
                .AsNoTracking()
                .Where(g => g.Genero.Any(s => s.Nome == livroGenero))
                .Include(i => i.Editora)
                .ThenInclude(i => i.Endereco)
                .ThenInclude(i => i.Cidade)
                .ThenInclude(i => i.Estado)
                .ToListAsync();
        }

        public async Task<Livro> ObterLivroPorId(int livroId)
        {
            return await _contexto.Livros
                .AsNoTracking()
                .Include(i => i.Genero)
                .Include(i => i.Editora)
                .ThenInclude(i => i.Endereco)
                .ThenInclude(i => i.Cidade)
                .ThenInclude(i => i.Estado)
                .SingleOrDefaultAsync(s => s.Id == livroId);
        }

        public async Task<Livro> ObterLivroPorNome(string livroNome)
        {
            return await _contexto.Livros
                .AsNoTracking()
                .Include(i => i.Genero)
                .Include(i => i.Editora)
                .ThenInclude(i => i.Endereco)
                .ThenInclude(i => i.Cidade)
                .ThenInclude(i => i.Estado)
                .SingleOrDefaultAsync(x => x.Nome == livroNome);
        }

        public async Task<IList<Livro>> ObterTodosLivros()
        {
            return await _contexto.Livros
                .AsNoTracking()
                .Include(i => i.Genero)
                .Include(i => i.Editora)
                .ThenInclude(i => i.Endereco)
                .ThenInclude(i => i.Cidade)
                .ThenInclude(i => i.Estado)                
                .ToListAsync();
        }
    }
}
