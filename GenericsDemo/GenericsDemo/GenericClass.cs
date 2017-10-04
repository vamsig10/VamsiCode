using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GenericsDemo
{
    class GenericClass
    {
        public void Swap<T>(T a, T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping");
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadLine();

        }
        
    }
}
