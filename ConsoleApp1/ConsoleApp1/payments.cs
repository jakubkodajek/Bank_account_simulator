using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class payments
    {
        // Create variables
        public string Name;
        public string TypeOfPayment;
        public string AccountNumber;
        public string IBAN;
        public float AmountOfMoney;
        public DateOnly DateOfPayment;
        public TimeOnly TimeOfPayment;

        

        // Create a constructor
        public payments(string Name, string TypeOfPayment, string AccountNumber, string IBAN , float AmountOfMoney, DateOnly DateOfPayment, TimeOnly TimeOfPayment)
        {
            this.Name = Name;
            this.TypeOfPayment = TypeOfPayment;             
            this.AccountNumber = AccountNumber;
            this.IBAN = IBAN;
            this.AmountOfMoney = AmountOfMoney;
            this.DateOfPayment = DateOfPayment;
            this.TimeOfPayment = TimeOfPayment;
        }

        // Create a method to show all payments and withdrawals
        public void ShowPayment()
        {
            if (Name != null && AmountOfMoney != 0)
            {
                Console.WriteLine("Type of payment: {0}", TypeOfPayment);
                Console.WriteLine("Name: {0}", Name);
                Console.WriteLine("Amount of money: ${0}", AmountOfMoney);
                Console.WriteLine("Date: {0}", DateOfPayment);
                Console.WriteLine("Time: {0} \n", TimeOfPayment);
            } else if (AccountNumber != null && AmountOfMoney != 0)
            {
                Console.WriteLine("Type of payment: {0}", TypeOfPayment);
                Console.WriteLine("Account number: {0}", AccountNumber);
                Console.WriteLine("Amount of money: ${0}", AmountOfMoney);
                Console.WriteLine("Date: {0}", DateOfPayment);
                Console.WriteLine("Time: {0} \n", TimeOfPayment);
            } else if (IBAN != null && AmountOfMoney != 0)
            {
                Console.WriteLine("Type of payment: {0}", TypeOfPayment);
                Console.WriteLine("IBAN: {0}", IBAN);
                Console.WriteLine("Amount of money: ${0}", AmountOfMoney);
                Console.WriteLine("Date: {0}", DateOfPayment);
                Console.WriteLine("Time: {0} \n", TimeOfPayment);
            } else if (TypeOfPayment != null && AmountOfMoney != 0)
            {
                Console.WriteLine("Type of payment: {0}", TypeOfPayment);
                Console.WriteLine("Amount of money: ${0}", AmountOfMoney);
                Console.WriteLine("Date: {0}", DateOfPayment);
                Console.WriteLine("Time: {0} \n", TimeOfPayment);
            }
        }

    }
}
