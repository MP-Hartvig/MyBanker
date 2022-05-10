using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Person
    {
        private int Age;
        private string Name;
        private string Address;
        private string Phone;
        private List<Account> BankAccounts;

        public Person(string name, int age, string address, string phone, List<Account> bankAccounts)
        {
            Name = name;
            Age = age;
            Address = address;
            Phone = phone;
            BankAccounts = bankAccounts;
        }

        private int GenerateRandomAge()
        {

        }

        private string GenerateRandomName()
        {
            
        }

        private string GenerateRandomAddress()
        {

        }

        private string GenerateRandomPhoneNumber()
        {

        }
    }
}
