using CulturaWeb.Domain.Validation;
using System.Collections.Generic;

namespace CulturaWeb.Domain.Entity
{
    public class Livro : Entity
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int EditoraId { get; set; }
        public Editora Editora { get; set; }
        public IList<Genero> Genero { get; set; }
        public StatusLivro Status { get; set; }
    }

    public enum StatusLivro
    {
        DisponivelParaEmprestimo,
        Emprestado
    }
}
