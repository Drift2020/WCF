using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hosts
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Chat_servis_library.Chat_servis)))
            {
                host.Open();
                Console.WriteLine("host start");
                Console.ReadLine();
            }
        }
    }
}
