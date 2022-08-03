namespace Sistema
{
    public class Program{
    
        static void Main(string[] args)
        {
            Pessoa andre = new Pessoa();
            Pessoa caique = new Pessoa();
            Pessoa lucas = new Pessoa();
            Pessoa raffael = new Pessoa ();

            andre.Endereco = "rua x";
            andre.nome = "Andre";

            Console.WriteLine(andre.Endereco);
            Console.WriteLine(andre.nome);
        }
    }
}