using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Entity
{
    public class Funcionario : Usuario
    {
        public string SetorId { get; set; }
        public Setor Setor { get; set; }
    }
}
