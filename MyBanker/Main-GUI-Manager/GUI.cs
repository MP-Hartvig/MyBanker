using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class GUI
    {
        Manager mana = new Manager();

        bool spacebarTerminator = false;
        bool enterTerminator = false;

        public void StartMenu()
        {
            // Bool to control the menu
            bool startMenu = true;

            while (startMenu)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("               MyBanker Assignment");
                Console.WriteLine("==================================================\n");
                Console.WriteLine("1. Create account and card");
                Console.WriteLine("2. Balance (NOT WORKING)");
                Console.WriteLine("3. Withdraw (NOT WORKING)");
                Console.WriteLine("4. International withdrawals (NOT WORKING)");
                Console.WriteLine("5. Exit");
                Console.Write("\r\nEnter a number: ");


                // Switch case for each menu point
                switch (Console.ReadLine())
                {
                    // Creates a journal
                    case "1":
                        Console.WriteLine("==================================================\n");
                        CreateCardMenu();
                        break;
                    //case "2":
                    //    Console.WriteLine("==================================================\n");

                    //    break;
                    //case "3":
                    //    Console.WriteLine("==================================================\n");

                    //    break;
                    //case "4":
                    //    Console.WriteLine("==================================================\n");

                    //    break;
                    // Exits the program
                    case "5":
                        ExitApplication();
                        break;
                    default:
                        break;
                }
            }
        }

        public void CreateCardMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("               MyBanker Assignment");
            Console.WriteLine("==================================================\n");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("\nEnter your age in numbers: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter your address: ");
            string address = Console.ReadLine();
            Console.Write("\nEnter your phone number: ");
            string phone = Console.ReadLine();

            Console.WriteLine("\nPress spacebar to create account and card.");

            while (spacebarTerminator == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    spacebarTerminator = true;
                }
            }

            mana.CreateAccountAndCard(name, age, address, phone);

            Console.WriteLine("\nPress enter to return to main menu.");

            while (enterTerminator == false)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    enterTerminator = true;
                }
            }

            StartMenu();
        }

        public void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
