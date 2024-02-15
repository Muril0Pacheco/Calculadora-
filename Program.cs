using System;

namespace Calculator
{
    class Program

    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem-vindo(a) a Calculator\n");
            Console.WriteLine("1 - SOMA\n2 - SUBTRAÇÃO\n3 - DIVISÃO\n4 - MULTIPLICAÇÃO\n5 - SAIR");
            Console.WriteLine("-----------------");
            Console.Write("\nDigite a opção  desejada: ");
            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Divisao();
                    break;

                case 4:
                    Multiplicacao();
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Digite um valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 + num2;
            Console.Write($"O resultado da soma é: {resultado}");

            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Digite um valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 - num2;
            Console.Write($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Digite um valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 / num2;
            Console.Write($"O resultado da divisão é: {resultado}");

            Console.ReadKey();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Digite um valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 * num2;
            Console.Write($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
        }
    }
}
