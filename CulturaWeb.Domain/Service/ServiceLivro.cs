using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Repository;
using CulturaWeb.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CulturaWeb.Domain.Service
{
    public class ServiceLivro : BaseService, IServiceLivro
    {
        private readonly IRepositoryLivro _repositoryLivro;

        public ServiceLivro(IRepositoryLivro repositoryLivro,
                            IServiceNotificador notificador) : base(notificador)
        {
            _repositoryLivro = repositoryLivro;
        }

        public async Task<bool> Cadastrar(Livro livro)
        {
            if(livro == null)
                throw new ArgumentNullException("livro");

            if (!ExecutarValidacao(new ValidadorLivro(), livro)) return false;
            
            await _repositoryLivro.Cadastrar(livro);
            return true;
        }
                
        public async Task<bool> Editar(Livro livro)
        {
            if (!ExecutarValidacao(new ValidadorLivro(), livro)) return false;

            var exists = await _repositoryLivro.ObterLivroPorId(livro.Id);

            if (exists == null)
                throw new Exception("Livro não existe");

            await _repositoryLivro.Editar(livro);
            return true;
        }

        public async Task<bool> Excluir(int livroId)
        {            
            var livro = await _repositoryLivro.ObterLivroPorId(livroId);

            if (livro == null)
                throw new ArgumentException("Livro não encontrado");

            await _repositoryLivro.Excluir(livro);
            return true;
        }

        public async Task<Livro> ObterLivroPorId(int livroId)
        {
            return await _repositoryLivro.ObterLivroPorId(livroId);
        }

        public async Task<IList<Livro>> ObterLivrosPorAutor(string livroAutor)
        {
            return await _repositoryLivro.ObterLivroPorAutor(livroAutor);
        }

        public async Task<IList<Livro>> ObterLivrosPorGenero(string livroGenero)
        {
            return await _repositoryLivro.ObterLivroPorGenero(livroGenero);
        }

        public async Task<IList<Livro>> ObterTodosLivros()
        {
            return await _repositoryLivro.ObterTodosLivros();
        }
    }
}
