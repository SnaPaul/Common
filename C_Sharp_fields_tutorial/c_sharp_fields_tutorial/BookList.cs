using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_fields_tutorial
{
    public class Book
    {
        public void Add(Book book)
        {

        }
    }

    public class List
    {
        public void Add(int number)
        {

        }
    }

    public class BookList
    {

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
