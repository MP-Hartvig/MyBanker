using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class StandardDebit : Card
    {
        private string cardNumber;

        public string CardNumber { get { return cardNumber; } set { CardNumber = value; } }

        public StandardDebit(Person person, Account account) : base(person, account)
        {
            cardNumber = GenerateCardNumber();
        }

        protected override string GenerateCardNumber()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string prefix = "2400";

            builder.Append(prefix);

            for (int i = 0; i < 13; i++)
            {
                builder.Append(random.Next(0, 9));
            }

            return builder.ToString();
        }
    }
}
