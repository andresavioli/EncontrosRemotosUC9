using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFísica : Pessoa
    {
        public string? cpf { get; set; }
        public DateTime dataNasc { get; set; }
    }
}