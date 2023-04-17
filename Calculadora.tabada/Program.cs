using System;
namespace MeuApp
{
    class program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            float opcao;
            Console.Clear();
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("Calculadora precisa.");
            Console.WriteLine("Desenvolvida por Carlos.");
            Console.WriteLine("Precione Enter para iniciar o programa.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Digite a opção desejada.\n");
            Console.WriteLine("1- Somar.");
            Console.WriteLine("2- Subtrair.");
            Console.WriteLine("3- dividir.");
            Console.WriteLine("4- multipicar.");
            Console.WriteLine("5- tabuada.");
            Console.WriteLine("6- Sair.\n");
            opcao = float.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: TabuadaDeMultiplicaco(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }
        static void TabuadaDeMultiplicaco()
        {
            int numero;
            int contador;
            Console.Clear();
            Console.WriteLine("Digite seu numero aqui: ");
            numero = int.Parse(Console.ReadLine());
            for (contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} - {contador} = {numero * contador}");

            }
            Console.ReadKey();
            Menu();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu reultado é: " + (valor1 + valor2));
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu reultado é: " + (valor1 - valor2));
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu reultado é: " + (valor1 / valor2));
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("O seu reultado é: " + (valor1 * valor2));
            Console.ReadKey();
            Menu();
        }
    }
}
