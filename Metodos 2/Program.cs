namespace Metodos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Análise de Triangulos");
            Console.WriteLine("=====================");

            Console.WriteLine("Digite o valor da base do triangulo: ");
            double ba = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do triangulo:");
            double al = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            BaseAltura(ba, al);

        }
        static void BaseAltura(double a, double b)
        {
            double x = (b * a) / 2;
            Console.WriteLine(x);

        }
    }
}
