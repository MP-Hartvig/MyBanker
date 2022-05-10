using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        private Person AssociatedPerson;
        private Account AssociatedAccount;

        public Card(Person person, Account account)
        {
            AssociatedPerson = person;
            AssociatedAccount = account;
        }

        protected virtual string GenerateCardNumber()
        {
            return null;
        }
    }
}
