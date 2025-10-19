using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ChangeUnidirectionalAssociationtoBidirectional_24
{
    public class Order
    {
        private Customer customer;

        // Dominant side: Order chịu trách nhiệm thiết lập quan hệ
        public Order(Customer customer)
        {
            SetCustomer(customer);
        }

        public void SetCustomer(Customer newCustomer)
        {
            customer = newCustomer;
            newCustomer.AddOrder(this);  // thiết lập liên kết ngược
        }

        public Customer GetCustomer()
        {
            return customer;
        }
    }

}
