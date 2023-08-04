using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class BankAccount
    {
        private readonly int accountNumber;
        private string? accountHolderName;
        private double? balance;

        public string? AccountHolderName { get => accountHolderName; set => accountHolderName = value; }
        public double? Balance { get => balance; set => balance = value; }

        public BankAccount(int accountNumber, string? accountHolderName)
        {
            this.accountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }
        public void depositAmount(double amount) { 
            Balance += amount;
            Console.WriteLine("Successfully Deposited");
        }
        public void withdrawAmount(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Successfully Withdrew");
            }
            else {
                Console.WriteLine("Insuffient Balance");
            }
            
        }
        public void displayAccountDetails() {
            Console.WriteLine("Account Number :" + accountNumber);
            Console.WriteLine("Account Holder Name :" + AccountHolderName);
            Console.WriteLine("Account Balance :" + Balance);
        }
    }
}
