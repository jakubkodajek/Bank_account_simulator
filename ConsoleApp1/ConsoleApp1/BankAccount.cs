using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        // Create variables
        public string TypeOfAccount;
        public string NameOfOwner;
        public string AccountNumber;
        public string IBAN;
        public float Balance;
        public DateTime BankAccountEstablishmentDateAndTime;

        // Create a constructor
        public BankAccount(string TypeOfAccount, string NameOfOwner, string AccountNumber, string IBAN, float Balance, DateTime BankAccountEstablishmentDateAndTime)
        {
            this.TypeOfAccount = TypeOfAccount;
            this.NameOfOwner = NameOfOwner;
            this.AccountNumber = AccountNumber;
            this.IBAN = IBAN;
            this.Balance = Balance;
            this.BankAccountEstablishmentDateAndTime = BankAccountEstablishmentDateAndTime;
        }

        // Create a method to show all information about the account
        public void ShowInfo()
        {
            Console.WriteLine("Type of account: {0}", TypeOfAccount);
            Console.WriteLine("Name of owner: {0}", NameOfOwner);
            Console.WriteLine("Account number: {0}", AccountNumber);
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("Balance: ${0}", Balance);
            Console.WriteLine("Bank account establishment date and time: {0} \n", BankAccountEstablishmentDateAndTime);
        }

        // Create a method to show the balance
        public void ShowBalance()
        {
            Console.WriteLine("Your balance is: ${0}\n", Balance);
        }
    }
}
