using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Account
    {
        private Person Client;
        private string RegistrationNumber = "3520";
        private string AccountNumber;
        //private int Balance;
        private List<Card> AssociatedCards;

        public Account(Person person, List<Card> associatedCards)
        {
            Client = person;
            GenerateAccountNumber();
            AssociatedCards = associatedCards;
        }

        private void GenerateAccountNumber()
        {
            Random random = new Random();

            StringBuilder sb = new StringBuilder();

            string startNumber = random.Next(1, 10).ToString();

            sb.Append(startNumber);

            for (int i = 0; i < 10; i++)
            {
                sb.Append(random.Next(0, 10));
            }

            AccountNumber = sb.ToString();
        }

        //private int GenerateBalance()
        //{
        //    return 0;
        //}

        //private int WithdrawFunds()
        //{
        //    return 0;
        //}

        //private int DepositFunds()
        //{
        //    return 0;
        //}
    }
}
