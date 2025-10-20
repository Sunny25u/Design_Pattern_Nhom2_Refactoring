using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(CalculatePay(40, true));
        Console.WriteLine(CalculatePay(0, true));
        Console.WriteLine(CalculatePay(40, false));
    }

    static double CalculatePay(int hoursWorked, bool isEmployeeActive)
    {
        if (isEmployeeActive)
        {
            if (hoursWorked > 0)
            {
                double payRate = 15.0;
                return hoursWorked * payRate;
            }
            else
            {
                return 0; // Không làm thì không trả
            }
        }
        else
        {
            return 0; // Nhân viên nghỉ việc
        }
    }
}