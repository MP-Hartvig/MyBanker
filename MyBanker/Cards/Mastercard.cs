using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    public class Mastercard : Card, IExpiryDate
    {
        private string CardNumber;
        private int DailyWithdrawalAmount = 5000;
        private int MonthlyWithoutdrawalAmount = 30000;
        private int OverdraftAmount = 40000;
        private DateTime ExpiryDate;

        public Mastercard(Person person, Account account) : base(person, account)
        {
            CardNumber = GenerateCardNumber();
            ExpiryDate = GenerateExpiryDate();
        }

        protected override string GenerateCardNumber()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string[] prefix = new string[5];
            prefix[0] = "51";
            prefix[1] = "52";
            prefix[2] = "53";
            prefix[3] = "54";
            prefix[4] = "55";

            builder.Append(prefix);

            for (int i = 0; i < 15; i++)
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
