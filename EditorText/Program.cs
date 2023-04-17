using System.IO;
namespace EditorText
{
    class EditorText
    {
        static void Main(String[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao editor de texto 1.0.");
            Console.WriteLine("\nDigite a opção desejada:");
            Console.WriteLine("1- Abrir arquivo.");
            Console.WriteLine("2- Criar novo arquivo.");
            Console.WriteLine("0- Sair.\n");
            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: LerArquivo(); break;
                case 2: Editar(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void LerArquivo()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do  seu arquivo?");
            string path = Console.ReadLine();
            using (var file = new StreamReader(path))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto aqui:");
            Console.WriteLine("----------------------");
            string texto = "";
            do
            {
                texto += Console.ReadLine();
                texto += System.Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Salvar(texto);
        }
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("  Salve seu arquivo aqui:");
            var path = Console.ReadLine();
            using (var file = new StreamWriter(path))
            {
                file.Write(texto);
            }
            Console.WriteLine($"Aqruivo {path} Salvo com sucesso!");

            Console.ReadLine();
            Menu();

        }
    }
}