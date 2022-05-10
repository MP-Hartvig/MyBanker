using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class GUI
    {
        public void StartMenu()
        {
            Manager mana = new Manager();

            // Bool to control the menu
            bool startMenu = true;

            while (startMenu)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("               MyBanker Assignment");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("1. Start the system");
                Console.WriteLine("2. Balance");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. International withdrawals");
                Console.WriteLine("5. Exit");
                Console.Write("\r\nEnter a number: ");


                // Switch case for each menu point
                switch (Console.ReadLine())
                {
                    // Creates a journal
                    case "1":
                        Console.WriteLine("==================================================\n");

                        break;
                    // Loads a journal
                    case "2":
                        Console.WriteLine("==================================================\n");

                        break;
                    // Loads a journal
                    case "3":
                        Console.WriteLine("==================================================\n");

                        break;
                    // Loads a journal
                    case "4":
                        Console.WriteLine("==================================================\n");

                        break;
                    // Exits the program
                    case "5":
                        startMenu = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
