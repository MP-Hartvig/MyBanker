using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Person
    {
        private int age;
        private string name;
        private string address;
        private string phone;
        private List<Account> BankAccounts;

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Phone { get { return phone; } set { phone = value; } }

        public Person(string fullName, int currentAge, string homeAddress, string telephone, List<Account> bankAccounts)
        {
            name = fullName;
            age = currentAge;
            address = homeAddress;
            phone = telephone;
            BankAccounts = bankAccounts;
        }

        //private int GenerateRandomAge()
        //{

        //}

        //private string GenerateRandomName()
        //{
            
        //}

        //private string GenerateRandomAddress()
        //{

        //}

        //private string GenerateRandomPhoneNumber()
        //{

        //}
    }
}
