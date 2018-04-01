using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_fields_tutorial
{
    public class Customer
    {
        private int _id;
        private string _name;
        //private string _state;
        private readonly List<Order> _orders = new List<Order>();

        public Customer(int id)
        {
            this._id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this._name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }

        public void addOrders(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> getOrders()
        {
            return _orders;
        }

    }
}
