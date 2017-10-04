using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string x, y;
            a = 1;
            b = 2;
            x = "abc";
            y = "xyz";

            Console.WriteLine("Before Swapping");
            Console.WriteLine("a={0},b={1}",a.ToString(),b.ToString());
            Console.WriteLine("x={0},y={1}", x, y);

            GenericClass obj =new GenericClass();
            obj.Swap<int?>(a,b);
            obj.Swap<string>(x, y);

        }
    }
}
