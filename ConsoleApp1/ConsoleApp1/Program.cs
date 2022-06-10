using System;

namespace ConsoleApp1
{
    public class BankAccount
    {
        private double balance = 0;
        public void Deposit(double depositted)
        {
            if (depositted > 0)
            {
                balance += depositted;
            }
            Console.WriteLine($"Deposited {depositted}");
        }
            public double GetBalance() {
                return balance;
            }


        static void Main(string[] args)
        {
            BankAccount Bank = new BankAccount();
            Console.WriteLine($"Initial Balance: {Bank.GetBalance()}");
            Bank.Deposit(500);
            Console.WriteLine($"New Balance: {Bank.GetBalance()}");


        }
    }
}
