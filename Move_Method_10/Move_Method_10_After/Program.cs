// Lớp Account giữ thông tin tài khoản
class Account
{
    public double Balance { get; set; }
    public AccountType Type { get; set; }

    // ✅ Giờ chỉ gọi lại phương thức trong AccountType
    public double GetOverdraftCharge()
    {
        return Type.GetOverdraftCharge(Balance);
    }
}

// Lớp AccountType — nơi phương thức được "di chuyển" tới
class AccountType
{
    public bool IsPremium { get; set; }

    // 🔹 Phương thức được "Move" sang đây
    public double GetOverdraftCharge(double balance)
    {
        if (IsPremium)
        {
            double result = 10;
            if (balance < 0)
                result += (-balance * 0.1);
            return result;
        }
        else
        {
            return (balance < 0) ? (-balance * 0.2) : 0;
        }
    }
}
