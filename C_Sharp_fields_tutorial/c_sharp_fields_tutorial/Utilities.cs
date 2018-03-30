using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_fields_tutorial
{
    // Generics could be:
    // Where T : IComparable 
    // Where T : Product (own class Product)
    // Where T : struct
    // Where T : class
    // Where T : new() (has a default constructor)
    class Utilities<T> where T: IComparable, new()
    {
        public int Max (int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
