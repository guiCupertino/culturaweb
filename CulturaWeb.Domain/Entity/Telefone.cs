using CulturaWeb.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CulturaWeb.Domain.Entity
{
    public class Telefone : Entity
    {
        public string DDD { get; set; }
        public string NumeroTelefone { get; set; }
    }
}
