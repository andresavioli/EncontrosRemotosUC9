namespace Sistema
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@$"
=====================================================
!                                                   !
!              Bem vindo ao Sistema                 !
!                                                   !
=====================================================");

    Console.Write("Iniciando ");

    for (var contador = 0; contador < 10; contador++){
        Console.Write("#");
        Thread.Sleep(500);
    }

Console.Clear();

string? opcao;

do{
    Console.WriteLine(@$"
====================================
!        1 - Pessoa Fisica         !
!        2 - Pessoa Juridica       !
!        0 - Sair                  !
====================================");

    opcao = Console.ReadLine();
switch (opcao){
    case "1":
    break;
    case "2":
    break;
    case "0":
    break;
    default:
    Console.WriteLine("Entrada não reconhecida");
    break;
}
} while (opcao != "0");
Console.ResetColor();





/*
            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 100;
            end.complemento = "Qualquer coisa";
            end.enderecoComercial = false;

            PessoaFísica pf = new PessoaFísica();
            pf.endereco = end;
            pf.nome = "Andre Savioli";
            pf.cpf = "645132465";
            pf.dataNascimento = new DateTime(1992, 06, 22);

            PessoaJuridica pj = new PessoaJuridica();
            pj.cnpj = "55.555.555/0001";

            Console.WriteLine($"Rua: {pf.endereco.logradouro}, {pf.endereco.numero}");
            //concatenação
            Console.WriteLine("O " + pf.nome + " mora na " + pf.endereco.logradouro + ", número " + pf.endereco.numero);
            //forma não-inteligente
            Console.WriteLine(pf.endereco.logradouro);
            Console.WriteLine(pf.endereco.numero);
            Console.WriteLine(pf.endereco.complemento);

            bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

            if (idadeValida == true)
            {
                System.Console.WriteLine("Cadastro aprovado");
            }
            else
            {
                Console.WriteLine("Cadastro reprovado");
            }
            bool validarCNPJ = pj.ValidarCNPJ(pj.cnpj);

            if (validarCNPJ == true)
            {
                Console.Write("CPNJ válido");
            }
            else
            {
                Console.Write("CNPJ inválido");*/
            }
        }
    }


