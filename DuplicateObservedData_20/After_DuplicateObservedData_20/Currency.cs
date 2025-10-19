using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_DuplicateObservedData_20
{
    public class Currency
    {
        public string Code { get; }  // Khong co setter => bat bien

        public Currency(string code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            if (obj is Currency otherCurrency)
            {
                return Code == otherCurrency.Code;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override string ToString()
        {
            return $"Currency Code: {Code}";
        }
    }
}
