using System;

namespace MoveField_After
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Gán lãi suất cho loại tài khoản
            AccountType type = new AccountType(0.05);

            // 🔹 Tạo tài khoản kèm loại tài khoản
            Account acc = new Account(type, 1000);

            Console.WriteLine("Lãi suất: " + acc.Type.InterestRate);
            Console.WriteLine("Tiền lãi: " + acc.CalculateInterest());
        }
    }

    // ✅ Lớp Account giờ chỉ giữ tham chiếu đến AccountType
    class Account
    {
        public AccountType Type { get; }
        private double _balance;

        public Account(AccountType type, double balance)
        {
            Type = type;
            _balance = balance;
        }

        public double CalculateInterest()
        {
            // 🔹 Gọi field InterestRate từ AccountType
            return _balance * Type.InterestRate;
        }
    }

    // ✅ Field InterestRate được "Move" sang đúng lớp
    class AccountType
    {
        public double InterestRate { get; }

        public AccountType(double interestRate)
        {
            InterestRate = interestRate;
        }
    }
}
