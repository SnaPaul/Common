using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_fields_tutorial
{
    public class Customer
    {
        private int Id;
        private string Name;
        private readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }

        public void addOrders(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> getOrders()
        {
            return Orders;
        }
    }
}
