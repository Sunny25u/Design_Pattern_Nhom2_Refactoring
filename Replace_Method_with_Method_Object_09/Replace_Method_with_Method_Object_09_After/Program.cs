// 🔹 Tạo một lớp riêng để chứa logic của phương thức Gamma
class GammaCalculator
{
    private readonly Account _account;
    private readonly int _inputVal;
    private readonly int _quantity;
    private readonly int _yearToDate;
    private int _importantValue1;
    private int _importantValue2;
    private int _importantValue3;

    // 🔹 Khởi tạo đối tượng với các giá trị cần thiết
    public GammaCalculator(Account account, int inputVal, int quantity, int yearToDate)
    {
        _account = account;
        _inputVal = inputVal;
        _quantity = quantity;
        _yearToDate = yearToDate;
    }

    // 🔹 Phương thức tính toán chính – thay cho hàm Gamma ban đầu
    public int Compute()
    {
        _importantValue1 = (_inputVal * _quantity) + _account.Balance;
        _importantValue2 = (_inputVal * _yearToDate) + 100;
        if ((_yearToDate - _importantValue1) > 100)
        {
            _importantValue2 -= 20;
        }
        _importantValue3 = _importantValue2 * 7;
        return _importantValue3 - 2 * _importantValue1;
    }
}

// 🔹 Lớp Account giờ chỉ cần gọi lại lớp trên
class Account
{
    public int Balance { get; }

    public Account(int balance)
    {
        Balance = balance;
    }

    public int Gamma(int inputVal, int quantity, int yearToDate)
    {
        // ✅ Thay vì xử lý trực tiếp, dùng “Method Object” để tính toán
        return new GammaCalculator(this, inputVal, quantity, yearToDate).Compute();
    }
}
