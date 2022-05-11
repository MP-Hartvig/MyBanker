using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        private Person associatedPerson;
        private Account associatedAccount;

        public Person AssociatedPerson
        {
            get { return associatedPerson; }
            set { associatedPerson = value; }
        }

        public Account AssociatedAccount
        {
            get { return associatedAccount; }
            set { associatedAccount = value; }
        }

        public Card(Person person, Account account)
        {
            associatedPerson = person;
            associatedAccount = account;
        }

        protected virtual string GenerateCardNumber()
        {
            return null;
        }
    }
}
