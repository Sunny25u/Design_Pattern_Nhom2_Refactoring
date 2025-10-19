using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_ChangeReferenceToValue_19
{
    public class Currency
    {
        public string Code { get; set; }  // Co setter => co the thay doi

        public Currency(string code)
        {
            Code = code;
        }

        public override string ToString()
        {
            return $"Currency Code: {Code}";
        }
    }
}
