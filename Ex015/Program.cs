﻿namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o gênero: ");
            genero = Console.ReadLine().ToUpper();
            

            while(genero != "F" && genero != "M")
            {
                Console.Write("Digite o gênero: ");
                genero = Console.ReadLine();


            }

            Console.WriteLine("Bem-vindos e bem-vindas a curso de C#!");


        }
    }
}
