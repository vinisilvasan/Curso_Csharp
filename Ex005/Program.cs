namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite a primeira nota");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a proxima nota");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A sua média é:");

            num3 = (num1 + num2) / 2;

            Console.WriteLine("{0} + {1} / 2 = {2}", num1, num2, (num3 - num1) / 2);

         







        }
    }
}
