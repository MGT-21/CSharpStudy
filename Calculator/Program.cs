using System;

namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Bem vindo a Calculadora C#");
            Console.WriteLine("");

            Console.WriteLine("Qual operação você deseja realizar ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Encerrar aplicação")

            Console.WriteLine("------------");

            Console.Write("Selecione uma das opções acima ");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Multiplicacao(); break;

                case 4: Divisao(); break;

                case 5: System.Environment.Exit(0); break;
                    
                default: 
                    Console.WriteLine("Opção invalida"); 
                    Console.ReadKey();
                    Menu();
                    break;  
            }


        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
 
            Console.WriteLine($"O resultado da soma é: {v1 + v2}");

            Console.ReadKey();
            Console.WriteLine("");
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {v1 - v2}");

            Console.ReadKey();
            Console.WriteLine("");
            Menu();


        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {v1 / v2}");

            Console.ReadKey();
            Console.WriteLine("");
            Menu();
            
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é: {v1 * v2}");

            Console.ReadKey();
            Console.WriteLine("");
            Menu();
        }
    }

}
