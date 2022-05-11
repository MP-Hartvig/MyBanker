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
        private string cardNumber;
        private int monthlyWithoutdrawalAmount = 25000;
        private int overdraftAmount = 20000;
        private DateTime expiryDate;

        // I know this isn't the way to go, but will have to do until i learn a better approach.
        public string CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public int MonthlyWithoutdrawalAmount { get { return monthlyWithoutdrawalAmount; } set { monthlyWithoutdrawalAmount = value; } }
        public int OverdraftAmount { get { return overdraftAmount; } set { overdraftAmount = value; } }
        public DateTime ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }

        public Visa(Person person, Account account) : base(person, account)
        {
            cardNumber = GenerateCardNumber();
            expiryDate = GenerateExpiryDate();
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
