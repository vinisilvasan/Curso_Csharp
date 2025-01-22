namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento;

            Console.WriteLine("Cálculo de Salário.");

            Console.WriteLine("Digite aqui o seu salario: ");
            salario = Convert.ToInt32(Console.ReadLine());

            if (salario > 2500)
            {

                aumento = (salario * 0.05);
                Console.WriteLine("Seu aumento é de: {0}", aumento);
                aumento = salario + (salario * 0.05);
                Console.WriteLine("seu salário é de: {0}", aumento);

            }
            else if (salario > 1250)
            {
                aumento = (salario * 0.10);
                Console.WriteLine("Seu aumento é de: {0}", aumento);
                aumento = salario + (salario * 0.10);
                Console.WriteLine("Seu salário é de: {0}", aumento);

            }
            else if(salario <= 1250)
            {
                aumento = (salario * 0.15);
                Console.WriteLine("Seu aumento é de: {0}", aumento);
                aumento = salario + (salario * 0.15);
                Console.WriteLine("Seu salário final é de: {0}", aumento);

            }
            
            

            

            


        }
    }
}
