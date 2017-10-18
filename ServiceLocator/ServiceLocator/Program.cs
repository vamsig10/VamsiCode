using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            Console.WriteLine(client.Start(3,5).ToString());
            Console.Read();
        }
    }
}
