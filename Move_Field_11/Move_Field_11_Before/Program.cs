using System;

namespace MoveField_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountType type = new AccountType();
            Account acc = new Account(type, 1000);

            Console.WriteLine("Lãi suất: " + acc.InterestRate);
            Console.WriteLine("Tiền lãi: " + acc.CalculateInterest());
        }
    }

    // ❌ Field interestRate đang nằm ở lớp Account
    class Account
    {
        public double InterestRate; // nên thuộc về AccountType
        private AccountType _type;
        private double _balance;

        public Account(AccountType type, double balance)
        {
            _type = type;
            _balance = balance;
            InterestRate = 0.05; // hardcode lãi suất ở đây
        }

        public double CalculateInterest()
        {
            return _balance * InterestRate;
        }
    }

    class AccountType
    {
        // hiện chưa có field nào
    }
}
