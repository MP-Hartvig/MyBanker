using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class Card
    {
        private string Name;
        private string CardNumber;
        private string RegistrationNumber;
        private string AccountNumber;

        public Card(string name, string cardNumber, string regNr, string accNr)
        {
            Name = name;
            CardNumber = cardNumber;
            RegistrationNumber = regNr;
            AccountNumber = accNr;
        }

        public virtual string GenerateCardNumber()
        {
            return null;
        }
    }
}
