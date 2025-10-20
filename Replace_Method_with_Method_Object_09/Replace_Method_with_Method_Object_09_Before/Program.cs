class Account
{
    int _balance;

    public Account(int balance)
    {
        _balance = balance;
    }

    // 🧾 Phương thức tính số tiền trong khoảng thời gian
    public int Gamma(int inputVal, int quantity, int yearToDate)
    {
        int importantValue1 = (inputVal * quantity) + _balance;
        int importantValue2 = (inputVal * yearToDate) + 100;
        if ((yearToDate - importantValue1) > 100)
        {
            importantValue2 -= 20;
        }
        int importantValue3 = importantValue2 * 7;
        return importantValue3 - 2 * importantValue1;
    }
}
