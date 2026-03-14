using System;


namespace BankAccount
{
    internal class Bank
    {
        private double _balance;

        public double Balance
        {
            get { return _balance; }
        }

        public Bank(double amount=0)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid value for balance! Balance is set to 0.");
                amount = 0;
            }
            _balance=amount;
        }


        public void Deposit(double amount)
        {
            if (amount < 0)
                Console.WriteLine("Amount you want to add can't be negative.");
            else
            {
                _balance += amount;
                Console.WriteLine("{0} was successfully added to your balance.",amount);
                ShowBalance();
            }
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
                Console.WriteLine("Amount you want to withdraw can't be negative.");
            else if (_balance < amount)
                Console.WriteLine("Can't withdraw {0} from your balance.", amount);
            else
            {
                _balance -= amount;
                Console.WriteLine("You withdraw {0} from your balance.",amount);
            }
            ShowBalance();
        }

        public void ShowBalance()
        {
            Console.WriteLine("Your current balance:{0}\n ",Balance);
        }

        public void TransferTo(Bank other, double amount)
        {
            if (amount < 0)
                Console.WriteLine("Amount for transfer can't be negative.");
            else if(_balance < amount)
                Console.WriteLine("There is no enough money on your balance to make a transfer.");
            else
            {
                _balance -= amount;
                other.Deposit(amount);
                Console.WriteLine("{0} was successfully transfered",amount);
                ShowBalance();
            }
            
        }
    }
}
