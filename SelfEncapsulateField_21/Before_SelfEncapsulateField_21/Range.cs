using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_SelfEncapsulateField_21
{
    class Range
    {
        private int low, high;

        public Range(int low, int high)
        {
            this.low = low;
            this.high = high;
        }

        public bool Includes(int number)
        {
            return number >= low && number <= high;
        }

        public void PrintRange()
        {
            Console.WriteLine($"Range: [{low}, {high}]");
        }
    }
}
