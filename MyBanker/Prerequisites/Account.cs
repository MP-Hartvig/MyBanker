using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Account
    {
        private Person Client;
        private string RegistrationNumber = "3520";
        private string AccountNumber;
        private int Balance;
        private List<Card> AssociatedCards;

        public Account(Person person, string accNr, int balance, List<Card> associatedCards)
        {
            Client = person;
            AccountNumber = accNr;
            Balance = balance;
            AssociatedCards = associatedCards;
        }

        private int GenerateAccountNumber()
        {
            return 0;
        }

        private int GenerateBalance()
        {
            return 0;
        }

        private int WithdrawFunds()
        {
            return 0;
        }

        private int DepositFunds()
        {
            return 0;
        }
    }
}
