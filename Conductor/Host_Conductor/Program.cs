using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host_Conductor
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var host = new ServiceHost(typeof(Library_Conductor.Library_Conductor)))
            {
                host.Open();
                Console.WriteLine("host start");
                Console.ReadLine();
            }

        }
    }
}
