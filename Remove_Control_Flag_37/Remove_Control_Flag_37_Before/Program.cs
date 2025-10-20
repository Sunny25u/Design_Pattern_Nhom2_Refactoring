using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 7, 10, 15, 21, 30 };

        foreach (int num in numbers)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine($"Found number divisible by 3 and 5: {num}");
                return; // ✅ Bỏ control flag, thoát ngay khi tìm thấy
            }
        }

        Console.WriteLine("No number divisible by both 3 and 5 found.");
    }
}