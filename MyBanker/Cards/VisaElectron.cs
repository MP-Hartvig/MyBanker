﻿using MyBanker.Interfaces;
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
        private int MonthlyWithoutdrawalAmount = 10000;
        private DateTime ExpiryDate;

        public VisaElectron(Person person, Account account) : base(person, account)
        {
            CardNumber = GenerateCardNumber();
            ExpiryDate = GenerateExpiryDate();
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
