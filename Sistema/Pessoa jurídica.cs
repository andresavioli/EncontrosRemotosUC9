using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaJurídica : Pessoa
    {
        public string? cnpj { get; set; }
        public string? RazaoSocial { get; set; }
        
        public override void PagarImposto(float rendimento){}
        
    }
}