using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Hosst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(TestLibrary.Service1)))
            {
                host.Open();
                Console.WriteLine("host start");
                Console.ReadLine();
            }
        }
    }
}
