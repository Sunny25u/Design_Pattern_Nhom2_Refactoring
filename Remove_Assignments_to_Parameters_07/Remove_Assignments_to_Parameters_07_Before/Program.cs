int Discount(int inputVal, int quantity)
{
    if (quantity > 50)
    {
        inputVal -= 2;
    }
    else if (quantity > 100)
    {
        inputVal -= 5;
    }

    return inputVal;
}
