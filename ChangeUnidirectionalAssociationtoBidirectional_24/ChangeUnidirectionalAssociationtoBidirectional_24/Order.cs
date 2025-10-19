using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_ChangeUnidirectionalAssociationtoBidirectional_24
{
    public class Order
    {
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
        }

        public Customer GetCustomer()
        {
            return customer;
        }
    }
}
