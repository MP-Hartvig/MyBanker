using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Maestro : Card, IExpiryDate
    {
        private string CardNumber;
        private DateTime ExpiryDate;

        public Maestro(Person person, Account account) : base(person, account)
        {
            CardNumber = GenerateCardNumber();
            ExpiryDate = GenerateExpiryDate();
        }

        protected override string GenerateCardNumber()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string[] prefix = new string[9];
            prefix[0] = "5018";
            prefix[1] = "5020";
            prefix[2] = "5038";
            prefix[3] = "5893";
            prefix[4] = "6304";
            prefix[5] = "6759";
            prefix[6] = "6761";
            prefix[7] = "6762";
            prefix[8] = "6763";

            int randomIndex = random.Next(0, 9);

            builder.Append(prefix[randomIndex]);

            for (int i = 0; i < 16; i++)
            {
                builder.Append(random.Next(0, 9));
            }

            return builder.ToString();
        }

        public DateTime GenerateExpiryDate()
        {
            ExpiryDate = DateTime.Now;
            ExpiryDate.AddYears(5);
            ExpiryDate.AddMonths(8);
            return ExpiryDate;
        }
    }
}
