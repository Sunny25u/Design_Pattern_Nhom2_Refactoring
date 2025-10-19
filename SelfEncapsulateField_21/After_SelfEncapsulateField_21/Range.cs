using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_SelfEncapsulateField_21
{
    class Range
    {
        private int low, high;

        public Range(int low, int high)
        {
            this.low = low;
            this.high = high;
        }

        // Getter và Setter
        public int Low
        {
            get { return low; }
            set
            {
                if (value <= high) low = value;
                else Console.WriteLine("Low cannot be greater than High");
            }
        }

        public int High
        {
            get { return high; }
            set
            {
                if (value >= low) high = value;
                else Console.WriteLine("High cannot be less than Low");
            }
        }

        public bool Includes(int number)
        {
            return number >= Low && number <= High;
        }

        public void PrintRange()
        {
            Console.WriteLine($"Range: [{Low}, {High}]");
        }
    }
}
