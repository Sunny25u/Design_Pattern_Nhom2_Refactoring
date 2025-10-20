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
        if (!isEmployeeActive)
            return 0; // Guard clause 1: nhân viên không hoạt động → dừng sớm

        if (hoursWorked <= 0)
            return 0; // Guard clause 2: không làm → dừng sớm

        double payRate = 15.0;
        return hoursWorked * payRate; // ✅ luồng chính rõ ràng
    }
}