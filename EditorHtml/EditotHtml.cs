using System;
namespace EditorHtml
{
    public class Menu
    {
        public static void Edicao()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            TelaPrincipal();
            Telaecundaria();
        }
        public static void TelaPrincipal()
        {
            Console.Clear();
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            Console.Write("|");
            for (int ita = 0; ita <= 10; ita++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");

            Console.Write("+");

        }
        public static void Telaecundaria()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Html\n\n\n\n\n\n\n\n\n\n");
        }
    }
}