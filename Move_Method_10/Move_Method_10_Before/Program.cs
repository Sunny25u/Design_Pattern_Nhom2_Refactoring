// Lớp Account giữ thông tin tài khoản
class Account
{
    public double Balance { get; set; }
    public AccountType Type { get; set; }

    // ❌ Phương thức này thực ra dùng dữ liệu của AccountType nhiều hơn
    public double GetOverdraftCharge()
    {
        if (Type.IsPremium)
        {
            double result = 10;
            if (Balance < 0)
                result += (-Balance * 0.1);
            return result;
        }
        else
        {
            return (Balance < 0) ? (-Balance * 0.2) : 0;
        }
    }
}

// Lớp AccountType lưu loại tài khoản
class AccountType
{
    public bool IsPremium { get; set; }
}
