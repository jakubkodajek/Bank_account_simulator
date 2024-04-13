using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bank account simulation, enter your name and surname!");
            string userName = Console.ReadLine();
            // Create a object of BankAccount class
            BankAccount myAccount = new BankAccount("Plus Account", userName, "123456789/0800", "CZ80 9000 0800 8343", 0f, DateTime.Now);
            // Create a list of payments
            List<payments> paymentsList = new List<payments>();

            while (true) {
                // Show the user what they can do
                Console.WriteLine("Write \"INFO\" to get all information about the account, \"INCOME\" to add money to the account, \"WITHDRAW\" to withdraw money from the account, \"PAY\" to send money to another account, \"payments\" to show all payments and withdrawals and \"EXIT\" to exit the program");
                string input = Console.ReadLine();

                // Check what the user wants to do
                // If the user wants to get all information about the account
                if (input.Equals("info", StringComparison.OrdinalIgnoreCase))
                {
                    myAccount.ShowInfo();
                }
                // If the user wants to add money to the account
                else if (input.Equals("income", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("How much money do you want to add?");
                    float income = float.Parse(Console.ReadLine());
                    myAccount.Balance += income;
                    paymentsList.Add(new payments(null, "Income", null, null, income, DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
                    myAccount.ShowBalance();
                }
                // If the user wants to withdraw money from the account
                else if (input.Equals("withdraw", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("How much money do you want to withdraw?");
                    string TypeOfPayment = "withdraw";
                    float withdraw = float.Parse(Console.ReadLine());
                    myAccount.Balance -= withdraw;
                    myAccount.ShowBalance();
                    paymentsList.Add(new payments(null,"Withdraw",null,null,withdraw, DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
                }
                // If the user wants to send money to another account
                else if (input.Equals("pay", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Write \"NAME\" if you want to find them by name, \"ACCOUNT NUMBER\" if by account number or \"IBAN\" if by IBAN");
                    string payBy = Console.ReadLine();

                    // Check what the user wants to do
                    // He wants to find the account by name
                    if (payBy.Equals("name", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Who do you want to send the money to? Enter their name!");
                        string payTo = Console.ReadLine();
                        Console.WriteLine("How much money do you want to send?");
                        float pay = float.Parse(Console.ReadLine());
                        myAccount.Balance -= pay;
                        paymentsList.Add(new payments(payTo,"Pay",null,null, pay, DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
                    } 
                    // He wants to find the account by account number
                    else if (payBy.Equals("account number", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Who do you want to send the money to? Enter their account number!");
                        string payTo = Console.ReadLine();
                        Console.WriteLine("How much money do you want to send?");
                        float pay = float.Parse(Console.ReadLine());
                        myAccount.Balance -= pay;
                        paymentsList.Add(new payments(null,"Pay",payTo,null, pay, DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
                    }
                    // He wants to find the account by IBAN
                    else if (payBy.Equals("IBAN", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Who do you want to send the money to? Enter their IBAN!");
                        string payTo = Console.ReadLine();
                        Console.WriteLine("How much money do you want to send?");
                        float pay = float.Parse(Console.ReadLine());
                        myAccount.Balance -= pay;
                        paymentsList.Add(new payments(null,"Pay", null, payTo, pay,DateOnly.FromDateTime(DateTime.Now), TimeOnly.FromDateTime(DateTime.Now)));
                    }
                    // If the user entered something else
                    else
                    {
                        Console.WriteLine("Invalid input \n");
                    }

                    myAccount.ShowBalance();
                } 
                // If the user wants to show all payments and witdrawals 
                else if (input.Equals("payments", StringComparison.OrdinalIgnoreCase))
                {
                    for (int i = 0; i < paymentsList.Count; i++)
                    {
                        paymentsList[i].ShowPayment();
                    }
                }
                // If the user wants to exit the program
                else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input \n");
                }
            }   
        }
    }
}
