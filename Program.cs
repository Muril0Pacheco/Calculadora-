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
            Console.WriteLine("1 - SOMA\n2 - SUBTRAÇÃO\n3 - DIVISÃO\n4 - MULTIPLICAÇÃO\n5 - PORCENTAGEM\n6 - SAIR");
            Console.WriteLine("-----------------");
            Console.Write("\nDigite a opção desejada: ");
            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: MenuPorcentagem(); break;

                case 6: System.Environment.Exit(0); break;

                default: Menu(); break;
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
            Console.WriteLine("-------------------------------");
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
            Console.WriteLine("------------------------------------");
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
            Console.WriteLine("----------------------------------");
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
            Console.WriteLine("----------------------------------------");
            Console.Write($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
        }

        static void MenuPorcentagem()
        {
            Console.Clear();

            Console.WriteLine("1 - AUMENTO PERCENTUAL\n2 - DIMINUIÇÃO PERCENTUAL\n3 - VALOR CORRESPONDENTE A PORCENTAGEM DE UM NÚMERO");
            Console.Write("Digite a opção desejada: ");
            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AumentoPercentual();
                    break;

                case 2:
                    DiminuicaoPercentual();
                    break;

                case 3: 
                    ValorPorcentagem();
                    break;
            }
        }

        static void AumentoPercentual()
        {
            Console.Clear();

            Console.Write("Digite o valor: ");
            float num1 = float.Parse(Console.ReadLine().Replace('.', ','));
            Console.Write("Digite o aumento em porcentagem(SEM O SÍMBOLO -> %): ");
            float aumporc = float.Parse(Console.ReadLine().Replace('.', ','));
            float resporc = (num1 * aumporc) / 100;
            float resfinal = num1 + resporc;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Valor com o aumento porcentual: {resfinal}");

            Console.ReadKey();
        }

        static void DiminuicaoPercentual()
        {
            Console.Clear();

            Console.Write("Digite o valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a diminuição em porcentagem (SEM O SÍMBOLO -> %): ");
            float dimporc = float.Parse(Console.ReadLine().Replace('.', ','));
            float resporc = (num1 * dimporc) / 100;
            float resfinal = num1 - resporc;
            Console.WriteLine("------------------------------------------------------");
            Console.Write($"Valor com diminuição percentual: {resfinal}");

            Console.ReadKey();
        }


        static void ValorPorcentagem() 
        {
            Console.Clear();
            
            Console.Write("Digite um valor: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a porcentagem (SEM O SÍMBOLO -> %): ");
            float valporc = float.Parse(Console.ReadLine());
            float resfinal = (num1 * valporc)/100;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"A porcentagem corresponde ao valor: {resfinal}");

            Console.ReadKey();
        }
    }
}
