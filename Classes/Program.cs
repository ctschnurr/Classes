using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static Player player;
        static string input;
        static int output;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Player Creator!");
            Console.WriteLine("Create a new player? (Y)es / (N)o");

            ConsoleKeyInfo choice = Console.ReadKey(true);

            if (choice.Key == ConsoleKey.N)
            {
                return;
            }

            if (choice.Key == ConsoleKey.Y)
            {
                player = new Player();
            }

            while (choice.Key != ConsoleKey.Q)
            {
                Console.WriteLine(" Press any key to continue.");
                Console.ReadKey(true);

                PlayerDisplay();
                ShowMenu();

                choice = Console.ReadKey(true);
                
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.Write(" Please enter new name: ");
                    player.name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(" Name updated!");
                }

                if (choice.Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.Write(" Please enter new health value: ");
                    input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out output);
                    if (isNumber == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" That is not a valid value for health.");
                    }
                    else
                    {
                        player.health = output;
                        Console.WriteLine(" Health updated!");
                    }
                }

                if (choice.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    Console.Write(" Please enter new lives value: ");
                    input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out output);
                    if (isNumber == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" That is not a valid value for lives.");
                    }
                    else
                    {
                        player.lives = output;
                        Console.WriteLine(" Lives updated!");
                    }
                }

                if (choice.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    Console.Write(" Please enter new shield value: ");
                    input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out output);
                    if (isNumber == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" That is not a valid value for shield.");
                    }
                    else
                    {
                        player.shield = output;
                        Console.WriteLine(" Shield updated!");
                    }
                }

            }
        }

        static void PlayerDisplay()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Name: " + player.name);
            Console.WriteLine(" Health: " + player.health);
            Console.WriteLine(" Lives: " + player.lives);
            Console.WriteLine(" Shield: " + player.shield);
            Console.WriteLine();
        }

        static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine(" Please choose from the following options:");
            Console.WriteLine();
            Console.WriteLine(" (1) Modify Name");
            Console.WriteLine(" (2) Modify Health");
            Console.WriteLine(" (3) Modify Lives");
            Console.WriteLine(" (4) Modify Shield");
            Console.WriteLine(" (Q) Quit");
            Console.WriteLine();
        }

    }
}
