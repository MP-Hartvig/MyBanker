using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
    class VisaElectron : Card, IExpiryDate
    {
        private string CardNumber;
        private int monthlyWithoutdrawalAmount = 10000;
        private DateTime expiryDate;

        // I know this isn't the way to go, but will have to do until i learn a better approach.
        public int MonthlyWithoutdrawalAmount { get { return monthlyWithoutdrawalAmount; } set { monthlyWithoutdrawalAmount = value; } }
        public DateTime ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }

        public VisaElectron(Person person, Account account) : base(person, account)
        {
            CardNumber = GenerateCardNumber();
            expiryDate = GenerateExpiryDate();
        }

        protected override string GenerateCardNumber()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            string[] prefix = new string[6];
            prefix[0] = "4026";
            prefix[1] = "4175";
            prefix[2] = "4508";
            prefix[3] = "4844";
            prefix[4] = "4913";
            prefix[5] = "4917";

            int randomIndex = random.Next(0, 7);

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
            return ExpiryDate;
        }
    }
}
