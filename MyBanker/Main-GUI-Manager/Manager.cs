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
            cards.Add(mastercard);

            Console.WriteLine($"\n{cards.Count} card was created.");

            Console.WriteLine("\nThe following client information was received: ");
            Console.WriteLine("\nName: " + mastercard.AssociatedPerson.Name);
            Console.WriteLine("\nAge: " + mastercard.AssociatedPerson.Age);
            Console.WriteLine("\nAddress: " + mastercard.AssociatedPerson.Address);
            Console.WriteLine("\nPhone: " + mastercard.AssociatedPerson.Phone);

            Console.WriteLine("\nThe following account information was generated: ");
            Console.WriteLine("\nRegistration number: " + mastercard.AssociatedAccount.RegistrationNumber);
            Console.WriteLine("\nAccount number: " + mastercard.AssociatedAccount.AccountNumber);

            Console.WriteLine("\nThe following card information was generated: ");
            Console.WriteLine("\nCardnumber: " + mastercard.CardNumber);
            Console.WriteLine("\nExpiry date: " + mastercard.ExpiryDate); 
            Console.WriteLine("\nDaily withdrawal amount: " + mastercard.DailyWithdrawalAmount); 
            Console.WriteLine("\nMonthly withdrawal amount: " + mastercard.MonthlyWithoutdrawalAmount); 
            Console.WriteLine("\nMax overdraft amount: " + mastercard.OverdraftAmount); 
        }
    }
}
