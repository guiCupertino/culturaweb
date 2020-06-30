using CulturaWeb.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Entity
{
    public class Estado : Entity
    {
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
