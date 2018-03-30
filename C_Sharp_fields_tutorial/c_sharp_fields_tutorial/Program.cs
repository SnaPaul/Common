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
            //HandleCustomer();
            //HandleBooks();
            HandleNullable();
        }

        static void HandleCustomer()
        {
            var customer = new Customer(1);

            customer.addOrders(new Order());
            customer.addOrders(new Order());
            customer.addOrders(new Order());

            customer.Promote();

            Console.WriteLine("Customer count: " + customer.getOrders().Count.ToString());
        }

        static void HandleBooks()
        {
            //var book = new Book { Isbn = "1111", Title = "Very nice book" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());
        }

        static void HandleNullable()
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value? -> " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
