using MyBanker.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Manager
    {
        public void CreateAccountAndCard(string name, int age, string address, string phone)
        {
            List<Account> accounts = new List<Account>();
            Person person = new Person(name, age, address, phone, accounts);

            List<Card> cards = new List<Card>();
            Account account = new Account(person, cards);
            accounts.Add(account);

            Console.WriteLine($"\n{accounts.Count} account was created.");

            Mastercard mastercard = new Mastercard(person, account);
            Maestro maestro = new Maestro(person, account);
            Visa visa = new Visa(person, account);
            VisaElectron visaElectron = new VisaElectron(person, account);
            StandardDebit standardDebit = new StandardDebit(person, account);

            cards.Add(mastercard);
            cards.Add(maestro);
            cards.Add(visa);
            cards.Add(visaElectron);
            cards.Add(standardDebit);

            Console.WriteLine($"\n{cards.Count} cards were created.");

            Console.WriteLine("\nThe following client information was received:");
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("Phone: " + person.Phone);

            Console.WriteLine("\nThe following account information was generated:");
            Console.WriteLine("Registration number: " + account.RegistrationNumber);
            Console.WriteLine("Account number: " + account.AccountNumber);

            Console.WriteLine("\nThe following Mastercard was generated:");
            Console.WriteLine("Cardnumber: " + mastercard.CardNumber);
            Console.WriteLine("Expiry date: " + mastercard.ExpiryDate); // Doesn't work properly
            Console.WriteLine("Daily withdrawal amount: " + mastercard.DailyWithdrawalAmount); 
            Console.WriteLine("Monthly withdrawal amount: " + mastercard.MonthlyWithoutdrawalAmount); 
            Console.WriteLine("Max overdraft amount: " + mastercard.OverdraftAmount);

            Console.WriteLine("\nThe following Maestro card was generated:");
            Console.WriteLine("Cardnumber: " + maestro.CardNumber);
            Console.WriteLine("Expiry date: " + maestro.ExpiryDate); // Doesn't work properly

            Console.WriteLine("\nThe following Visa card was generated:");
            Console.WriteLine("Cardnumber: " + visa.CardNumber);
            Console.WriteLine("Expiry date: " + visa.ExpiryDate); // Doesn't work properly
            Console.WriteLine("Monthly withdrawal amount: " + visa.MonthlyWithoutdrawalAmount);
            Console.WriteLine("Max overdraft amount: " + visa.OverdraftAmount);

            Console.WriteLine("\nThe following Visa Electron card was generated:");
            Console.WriteLine("Cardnumber: " + visaElectron.CardNumber);
            Console.WriteLine("Expiry date: " + visaElectron.ExpiryDate); // Doesn't work properly

            Console.WriteLine("\nThe following Standard Debit card was generated: ");
            Console.WriteLine("Cardnumber: " + standardDebit.CardNumber);
        }
    }
}
