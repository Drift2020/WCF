using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.IO;

namespace Client
{
    [ServiceContract]
    [DeliveryRequirements(RequireOrderedDelivery = true)]
    // Чтобы обеспечить очередность обработки сообщений в том порядке, как они были отправлены
    public interface IMyFree
    {
        [OperationContract]
        string FreeSpace(string name);
    }
    [ServiceContract]
    public interface IMyTotal
    {
        [OperationContract]
        string TotalSpace(string name);
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            NetTcpBinding tcp = new NetTcpBinding(
              SecurityMode.Message /* защита обеспечивается механизмом SOAP */,
              true /* механизм контроля доставки будет включен. */);
            // tcp.ReliableSession.Ordered = true; // механизм контроля доставки будет включен.
            tcp.TransactionFlow = true; // привязка допускает использование транзакций
            //  ChannelFactory<> реализует среду выполнения со стороны клиента, 
            // а также создает каналы для передачи сообщений между клиентом и службой.
            ChannelFactory<IMyFree> factory = new ChannelFactory<IMyFree>(
                tcp,
                new EndpointAddress("net.tcp://localhost/MyDiskInfos/Ep1"));

            // создаем канал, по которому будут передаваться сообщения между нашим клиентом и службой
            IMyFree channel = factory.CreateChannel();

            CustomBinding MyBinding = new CustomBinding();
            MyBinding.Elements.Add(new TextMessageEncodingBindingElement());
            MyBinding.Elements.Add(new HttpTransportBindingElement());
            ChannelFactory<IMyTotal> factoryCustom = new ChannelFactory<IMyTotal>(
             MyBinding,
             new EndpointAddress("http://localhost:8084/MyDiskInfos/Ep2"));
            IMyTotal channelCustom = factoryCustom.CreateChannel();

            while (true)
            {
                Console.Write("1.Free\n2.Total\n3.Exit\nEnter value: ");

                var i = Console.ReadLine();
                if (i == "1")
                {
                    Console.Write("Enter disk name: ");
                    var str = Console.ReadLine();
                    string result = channel.FreeSpace(str);
                    Console.WriteLine("result: {0}", result);
                    Console.WriteLine("Для завершения нажмите <ENTER>\n");
                    Console.ReadLine();

                }

                else if (i == "2")
                {
                    // создаем канал, по которому будут передаваться сообщения между нашим клиентом и службой
                    Console.Write("Enter disk name: ");
                    var str = Console.ReadLine();
                   
                    string intresult = channelCustom.TotalSpace(str);
                    Console.WriteLine("result: {0}", intresult);
                    Console.WriteLine("Для завершения нажмите <ENTER>\n");
                    Console.ReadLine();
                }
                else if (i == "3")
                {
                    break;
                }
                Console.Clear();
            }
            factory.Close();
            factoryCustom.Close();
        }
    }
}
