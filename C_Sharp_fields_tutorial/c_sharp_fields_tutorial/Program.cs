using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_fields_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);

            customer.addOrders(new Order());
            customer.addOrders(new Order());

            customer.Promote();

            Console.WriteLine(customer.getOrders().Count);
        }
    }
}
