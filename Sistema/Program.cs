namespace Sistema
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<PessoaFísica> listaPf = new List<PessoaFísica>();
            static void BarraCarregamento(string texto){
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Thread.Sleep(500);
                Console.Write(texto);

                for (var contador = 0; contador < 10; contador++)
                {
                Console.Write("||");
                Thread.Sleep(500);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@$"
=====================================================
!                                                   !
!              Bem vindo ao Sistema                 !
!                                                   !
=====================================================");

BarraCarregamento("Iniciando ");

            string? opcao;

            do
            {
                Console.WriteLine(@$"
====================================
!       Pessoa Física              !
!       1 - Cadastrar              !
!       2 - Listar                 !
!       3 - Remover                !
!                                  !
!       Pessoa Jurídica            !
!       4 - Cadastrar              !
!       5 - Listar                 !
!       6 - Remover                !
====================================
!       0 - Sair                   !
====================================");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                    Endereco endPf = new Endereco();
                    Console.WriteLine("Digite seu logradouro.");
                    endPf.logradouro = Console.ReadLine();

                    Console.WriteLine("Digite o número de sua residência.");
                    endPf.numero = int.Parse(Console.ReadLine()); 

                    Console.WriteLine(@$"Digite o complemento.
                    Pressione ENTER para pular.");
                    endPf.complemento = Console.ReadLine();

                    Console.WriteLine("O Endereço fornecido é Comercial? (S = Sim /N = Não)");
                    string endComercial = Console.ReadLine().ToUpper();

                    if(endComercial == "S"){
                        endPf.enderecoComercial = true;
                    }else{
                        endPf.enderecoComercial = false;
                    }

                    PessoaFísica pf = new PessoaFísica();
                    pf.endereco = endPf;

                    Console.WriteLine("Digite seu CPF. Somente números.");
                    pf.cpf = Console.ReadLine();

                    Console.WriteLine("Digite seu nome.");
                    pf.nome = Console.ReadLine();

                    Console.WriteLine("Digite o valor do seu salário.");
                    pf.salario = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite sua data de nascimento [AAAA, MM, DD]");
                    pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                    bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);
                    if(idadeValida == true){
                        Console.WriteLine("Cadastro Aprovado");
                        listaPf.Add(pf);
                        Console.WriteLine(pf.PagarImposto(pf.salario));
                    }else{
                        Console.WriteLine("Cadastro Recusado. Idade insuficiente");
                    }

                    Console.WriteLine(endPf.logradouro);
                    Console.WriteLine(endPf.numero);
                    Console.WriteLine(endPf.complemento);
                    Console.WriteLine(endPf.enderecoComercial);
                    
                    Console.WriteLine(pf.cpf);
                    Console.WriteLine(pf.nome);
                    Console.WriteLine(pf.salario);
                    Console.WriteLine(pf.dataNascimento);
                        break;
                    case "2":
                    foreach(var cadaItem in listaPf){
                        Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                    }
                        break;
                    case "3":
                    Console.WriteLine("Digite o CPF do marginal");
                    string cpfProcurado = Console.ReadLine();
                    PessoaFísica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                    if(pessoaEncontrada != null){
                        listaPf.Remove(pessoaEncontrada);
                        Console.WriteLine("Marginal eliminado");
                    }else{
                        Console.WriteLine("CPF não encontrado");
                    }


                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "0":
                    Console.WriteLine("Obrigado por utilizar o sistema");
                    BarraCarregamento("Finalizando ");


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


