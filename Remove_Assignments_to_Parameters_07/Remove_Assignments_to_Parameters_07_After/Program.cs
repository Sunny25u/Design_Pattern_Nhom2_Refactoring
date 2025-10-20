int Discount(int inputVal, int quantity)
{
    int result = inputVal; // tạo biến tạm để thao tác

    if (quantity > 100)
    {
        result -= 5;
    }
    else if (quantity > 50)
    {
        result -= 2;
    }

    return result;
}
