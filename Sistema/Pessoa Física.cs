using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema
{
    public class PessoaFísica : Pessoa
    {
        public float salario { get; set; }
        public string? cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNascimento).TotalDays / 365;
            if (anos >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override float PagarImposto(float salario)
        {
            if (salario <= 1500)
            {
                return 0;
            }
            else if (salario > 1500 && salario <= 5000)
            {
                return salario * 3 / 100;
            }
            else if (salario > 5001)
            {
                return salario * 100 / 5;
            }
            else
            {
                return 0;
            }
        }
    }


}


