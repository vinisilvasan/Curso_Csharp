namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Vinicius");
            Soma(45555, 78784); 
        }

        static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá {nome}, seja bem vindo!");

        }
        static void Soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}");
            Console.WriteLine("A soma de {0} + {1} ´igual a {2}.", a, b, resultado);
            Console.WriteLine("A soma de " + a + " + " + b + " é igual a " + resultado);
        }
    }
}
