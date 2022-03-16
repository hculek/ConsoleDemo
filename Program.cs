using System;
using hculekConsoleDemoModules;

namespace hculekConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="hculek console demo";
            Menu();
        }

        private static void Menu()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Select option and press enter: " +
            "\n 0 = Exit program" +
            "\n 1 = Try all options" +
            "\n 2 = Fibonacci" +
            "\n 3 = Spell text backwards" +
            "\n 4 = Trim text and change all to lower case" +
            "\n 5 = Remove all but first $ character from text");

            int input = 0;

            try
            {
                input = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input value in incorrect format. Press any key to try again.");
                Console.ReadKey();
                Console.WriteLine();
                Menu();
            }

            OptionCaller(input);
        }


        private static void OptionCaller(int input)
        {
            switch (input)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    TryAll();
                    break;
                case 2:
                    Fibonacci.Get();
                    break;
                case 3:
                    Strings.ReverseString();
                    break;
                case 4:
                    Strings.TrimAndLower();
                    break;

                case 5:
                    Strings.RemoveCharacters();
                    break;
            }
            Console.WriteLine("\n");
            Menu();

        }

        private static void TryAll()
        {
            Fibonacci.Get();
            Strings.ReverseString();
            Strings.TrimAndLower();
        }


    }
}
