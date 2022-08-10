namespace Sistema
{
    public class Program{
    
        static void Main(string[] args)
        {
            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Qualquer coisa";
            end.enderecoComercial = false;

            PessoaFísica pf = new PessoaFísica();
            pf.endereco = end;
            pf.nome = "Andre Savioli";
            pf.cpf = "645132465";
            pf.dataNascimento = new DateTime (1992, 06, 22);

        Console.WriteLine($"Rua: {pf.endereco.logradouro}, {pf.endereco.numero}");
        //concatenação
        Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + ", número " + pf.endereco.numero);
        //forma não-inteligente
        Console.WriteLine(pf.endereco.logradouro);
        Console.WriteLine(pf.endereco.numero);
        Console.WriteLine(pf.endereco.complemento);

    bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

    if(idadeValida == true)
    {
        System.Console.WriteLine("Cadastro aprovado");
    }else{
        Console.WriteLine("Cadastro reprovado");
    }
        }
    }
}