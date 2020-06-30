using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulturaWeb.Api.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public EditoraViewModel Editora { get; set; }
        public IList<GeneroViewModel> Genero { get; set; }
    }
}
