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
        private string cardNumber;
        private int dailyWithdrawalAmount = 5000;
        private int monthlyWithoutdrawalAmount = 30000;
        private int overdraftAmount = 40000;
        private DateTime expiryDate;

        public string CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public int DailyWithdrawalAmount { get { return dailyWithdrawalAmount; } set { dailyWithdrawalAmount = value; } }
        public int MonthlyWithoutdrawalAmount { get { return monthlyWithoutdrawalAmount; } set { monthlyWithoutdrawalAmount = value; } }
        public int OverdraftAmount { get { return overdraftAmount; } set { overdraftAmount = value; } }
        public DateTime ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }

        public Mastercard(Person person, Account account) : base(person, account)
        {
            cardNumber = GenerateCardNumber();
            expiryDate = GenerateExpiryDate();
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

            builder.Append(prefix[random.Next(0, 5)]);

            for (int i = 0; i < 15; i++)
            {
                builder.Append(random.Next(0, 9));
            }

            return builder.ToString();
        }

        public DateTime GenerateExpiryDate()
        {
            expiryDate = DateTime.Now;
            expiryDate.AddYears(5);
            return expiryDate;
        }
    }
}
