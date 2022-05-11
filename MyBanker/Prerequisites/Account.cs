using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Account
    {
        private Person client;
        private string registrationNumber = "3520";
        private string accountNumber;
        private List<Card> associatedCards;
        //private int Balance;

        public Person Client
        {
            get { return client; }
            set { client = value; }
        }

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public Account(Person person, List<Card> associatedCardsList)
        {
            client = person;
            GenerateAccountNumber();
            associatedCards = associatedCardsList;
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
