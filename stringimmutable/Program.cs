using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringimmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("hello");
            Console.WriteLine(str);
            str.Append(" world");
            Console.WriteLine(str);
            str.Insert(11, "good morning");
            Console.WriteLine(str);
            str.Remove(5, 6);
            Console.WriteLine(str);
            int i = str.Capacity;
            Console.WriteLine(i);
            str.Clear();
            Console.WriteLine(str);
        }
    }
}
