using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new Service());
            Console.WriteLine(client.Start(7, 8));


            //var client1=new Client();
            //client1.Service=new Service();
            //client1.Start(5,6);

            Console.Read();
        }
    }
}
