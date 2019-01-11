using Client.Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new Service1.Service1Client("NetTcpBinding_IService1");

            //Console.WriteLine(client.DoWork(5, 2).ToString());

            //client.Close();

            EndpointAddress httpAdr1 = new EndpointAddress("http://localhost:8080/Service1");
            BasicHttpBinding HttpBinding = new BasicHttpBinding();
            Service1Client proxy = new Service1Client(HttpBinding, httpAdr1);
            Console.WriteLine(proxy.DoWork(5, 2).ToString());
        }
    }
}
