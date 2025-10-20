using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 7, 10, 15, 21, 30 };

        bool found = false; // ✅ Cờ điều khiển (control flag)
        foreach (int num in numbers)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine($"Found number divisible by 3 and 5: {num}");
                found = true; // đánh dấu tìm thấy
            }
        }

        if (!found)
        {
            Console.WriteLine("No number divisible by both 3 and 5 found.");
        }
    }
}
