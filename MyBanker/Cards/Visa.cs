using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class Visa : Card, IExpiryDate
    {
        private string CardNumber;
        private int MonthlyWithoutdrawalAmount = 25000;
        private int OverdraftAmount = 20000;
        private DateTime ExpiryDate;

        public Visa(Person person, Account account) : base(person, account)
        {
            CardNumber = GenerateCardNumber();
            ExpiryDate = GenerateExpiryDate();
        }

        protected override string GenerateCardNumber()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string prefix = "4";

            builder.Append(prefix);

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
            return ExpiryDate;
        }
    }
}
