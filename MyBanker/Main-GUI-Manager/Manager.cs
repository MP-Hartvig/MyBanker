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

            Mastercard mastercard = new Mastercard(person, account);

            cards.Add(mastercard);

            Console.WriteLine($"\n{cards.Count} card was created.");
        }
    }
}
