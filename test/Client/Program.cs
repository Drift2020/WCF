using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Service1.Service1Client("NetTcpBinding_IService1");

            Console.WriteLine(client.DoWork(5 , 2).ToString());

            client.Close(); 
        }
    }
}
