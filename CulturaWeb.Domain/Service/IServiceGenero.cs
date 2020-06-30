using CulturaWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Service
{
    public interface IServiceGenero
    {
        bool Cadastrar(Genero genero);
        bool Editar(Genero genero);
        bool Excluir(int generoId);
        IList<Genero> ObterTodosGeneros();
        Genero ObterGeneroPorId(int generoId);
    }
}
