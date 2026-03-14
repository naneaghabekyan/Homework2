using System;


namespace BankAccount
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("First client");
            Bank first = new Bank(15000);
            first.Deposit(120000);
            first.Withdraw(20000);

            Console.WriteLine("Second client");
            Bank second = new Bank();
            second.Deposit(120);
            second.Withdraw(20000);
            second.TransferTo(first, 14200);
            Console.WriteLine("First client's balance {0}.",first.Balance);

            Console.WriteLine("Third client");
            Bank third = new Bank(-12365);
            third.Deposit(120);
            third.Withdraw(-20000);

        }
    }
}
