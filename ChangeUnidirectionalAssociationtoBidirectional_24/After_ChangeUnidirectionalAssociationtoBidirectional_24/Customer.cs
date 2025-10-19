using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_ChangeUnidirectionalAssociationtoBidirectional_24
{
    public class Customer
    {
        public string Name { get; set; }
        private List<Order> orders = new List<Order>();

        public Customer(string name)
        {
            Name = name;
        }

        // Utility method (non-dominant side)
        public void AddOrder(Order order)
        {
            if (!orders.Contains(order))
            {
                orders.Add(order);
            }
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders;
        }
    }
}
