using CulturaWeb.Domain.Validation;
using System;

namespace CulturaWeb.Domain.Entity
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int TelefoneId { get; set; }
        public Telefone Telefone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }
    }
}
