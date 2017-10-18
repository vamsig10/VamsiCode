using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");

        }

        public int Serve2(int a, int b)
        {   
            return (a + b);
        }
    }
}
