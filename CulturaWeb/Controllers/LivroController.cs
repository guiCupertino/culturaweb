using AutoMapper;
using CulturaWeb.Api.ViewModels;
using CulturaWeb.Domain.Entity;
using CulturaWeb.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CulturaWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly IServiceLivro _serviceLivro;
        private readonly IMapper _mapper;
        private readonly IServiceNotificador _notificador;
        public LivroController(IServiceLivro serviceLivro, IMapper mapper, IServiceNotificador notificador)
        {
            _serviceLivro = serviceLivro;
            _mapper = mapper;
            _notificador = notificador;
        }

        [HttpGet]
        public async Task<IActionResult> ObterLivros()
        {
            var livros = await _serviceLivro.ObterTodosLivros();

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            var livroConvertido = _mapper.Map<IList<Livro>, IList<LivroViewModel>>(livros);

            return Ok(livroConvertido);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterLivroPorId(int id)
        {
            var livro = await _serviceLivro.ObterLivroPorId(id);

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            var livroConvertido = _mapper.Map<Livro, LivroViewModel>(livro);

            return Ok(livroConvertido);
        }

        [HttpGet("genero/{genero}")]
        public async Task<IActionResult> ObterLivroGenero(string genero)
        {
            if (string.IsNullOrWhiteSpace(genero))
                return BadRequest(new
                {
                    success = false,
                    messages = "Parâmetro de entrada {livroGenero} inválido!"
                });

            var livros = await _serviceLivro.ObterLivrosPorGenero(genero);

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            var livroConvertido = _mapper.Map<IList<Livro>, IList<LivroViewModel>>(livros);

            return Ok(livroConvertido);
        }

        [HttpGet("autor/{autor}")]
        public async Task<IActionResult> ObterLivroPorAutor(string autor)
        {
            if (string.IsNullOrWhiteSpace(autor))
                return BadRequest("Parâmetro de entrada {autor} inválido!");

            var livros = await _serviceLivro.ObterLivrosPorAutor(autor);

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            var livroConvertido = _mapper.Map<IList<Livro>, IList<LivroViewModel>>(livros);

            return Ok(livroConvertido);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] LivroViewModel livro)
        {
            var livroConvertido = _mapper.Map<LivroViewModel, Livro>(livro);            
            await _serviceLivro.Cadastrar(livroConvertido);

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            return Ok(new
            {
                success = true,
                messages = "Livro cadastrado com sucesso."
            });
        }

        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] LivroViewModel livro)
        {
            var livroConvertido = _mapper.Map<LivroViewModel, Livro>(livro);
            
            await _serviceLivro.Editar(livroConvertido);

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            return Ok(new
            {
                success = true,
                messages = "Livro editado com sucesso."
            });
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(int livroId)
        {            
            await _serviceLivro.Excluir(livroId);

            if (_notificador.TemNotificacao())
                return BadRequest(new
                {
                    success = false,
                    messages = _notificador.ObterNotificacoes()
                });

            return Ok(new
            {
                success = true,
                messages = "Livro excluido com sucesso."
            });
        }
    }
}