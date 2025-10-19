using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ReplaceDataValuewithObject_22
{
    class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetNameInUpperCase()
        {
            return name.ToUpper();
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(name);
        }
    }
}
