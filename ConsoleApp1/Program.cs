using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System;


class Program
{
    static void Main()
    {
        string entrada;
        int valor1;
        int valor2;

        bool continuar = true;

        while (continuar)
        {
            continuar = false;

            Console.WriteLine("-----Calculadora----");


            Console.WriteLine(" 1 para Soma");
            Console.WriteLine(" 2 para Subtração");
            Console.WriteLine(" 3 para Multiplicar");
            Console.WriteLine(" 4 para Divisão");
            Console.WriteLine(" 0 para Sair");

            Console.WriteLine("\nQual Opção você deseja? ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int escolha);
            Console.Clear();



            switch (escolha)
            {
                case 1: //Soma
                    Console.WriteLine("Você escolheu a operação [Soma]");
                    Console.WriteLine("\nDigite o 1° valor: ");
                    int.TryParse(Console.ReadLine(), out valor1);

                    Console.WriteLine("\nDigite o 2° valor: ");
                    int.TryParse(Console.ReadLine(), out valor2);

                    int soma = valor1 + valor2;
                    Console.WriteLine($"Resultado: {soma}");
                    break;

                case 2: //Subtração
                    Console.WriteLine("Você escolheu a operação [Subtração]");
                    Console.WriteLine("\nDigite o 1° valor: ");
                    int.TryParse(Console.ReadLine(), out valor1);

                    Console.WriteLine("\nDigite o 2° valor: ");
                    int.TryParse(Console.ReadLine(), out valor2);

                    int subtracao = valor1 - valor2;
                    Console.WriteLine($"Resultado: {subtracao}");
                    break;

                case 3: //Multiplicação
                    Console.WriteLine("Você escolheu a operação [Multiplicação]");
                    Console.WriteLine("\nDigite o 1° valor: ");
                    int.TryParse(Console.ReadLine(), out valor1);


                    Console.WriteLine("\nDigite o 2° valor: ");
                    int.TryParse(Console.ReadLine(), out valor2);

                    int multiplicacao = valor1 * valor2;
                    Console.WriteLine($"Resultado: {multiplicacao}");
                    break;

                case 4: //Divisão
                    Console.WriteLine("Você escolheu a operação [Divisão]");
                    Console.WriteLine("\nDigite o 1° valor: ");
                    int.TryParse(Console.ReadLine(), out valor1);

                    Console.WriteLine("\nDigite o 2° valor: ");C:\Users\leonardofranciulli\Desktop\Projetos\Conso
                    int.TryParse(Console.ReadLine(), out valor2);

                    if (valor2 != 0)
                    {
                        int divisao = valor1 / valor2;
                        Console.WriteLine($"Resultado: {divisao}");
                    }
                    else
                    {
                        Console.WriteLine($"Não é possível dividir por {valor2}.");

                    }
                    break;


                case 0:
                    Console.WriteLine("Você escolheu Sair do programa, Até Mais.");
                    break;
            }

            Console.WriteLine("Pressione Enter para continuar ou escreva Sair ");


            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                continuar = true;
                Console.Clear();
            }
            else if (Console.ReadLine() == "Sair")
            {
                Environment.Exit(0);
            }

        }



    }
}







