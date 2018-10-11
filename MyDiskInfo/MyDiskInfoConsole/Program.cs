using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.ServiceModel.Channels;
using System.IO;
namespace MyDiskInfoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 * ServiceHost позволяет реализовать среду выполнения для класса службы.
 * ServiceHost автоматически формирует полное описание службы в своем свойстве Description, 
 * представляющем собой объект класса ServiceDescription. 
 * Кроме этого,  ServiceHost создает и конфигурирует оконечные точки службы, 
 * применяет настройки безопасности и начинает прослушивание входящих запросов от клиентов. 
 * */
            ServiceHost sh = new ServiceHost(typeof(MyDiskInfos));

            NetTcpBinding tcp = new NetTcpBinding(
                SecurityMode.Message /* защита обеспечивается механизмом SOAP */,
                true /* механизм контроля доставки будет включен. */);
            // tcp.ReliableSession.Ordered = true; // механизм контроля доставки будет включен.
            tcp.TransactionFlow = true; // привязка допускает использование транзакций

            sh.AddServiceEndpoint(
              typeof(IMyFree),
              tcp,
              "net.tcp://localhost/MyDiskInfo/Ep1");

            CustomBinding MyBinding = new CustomBinding();
            MyBinding.Elements.Add(new TextMessageEncodingBindingElement());
            MyBinding.Elements.Add(new HttpTransportBindingElement());

            sh.AddServiceEndpoint(
              typeof(IMyTotal),
              MyBinding,
              "http://localhost:8084/MyDiskInfo/Ep2");

            sh.CloseTimeout = TimeSpan.FromSeconds(20); // время тайм-аута для блокирования клиента при вызове Close()
            sh.Open();
            Console.WriteLine("Enter value for end this program");
            Console.ReadLine();
            sh.Close();
        }

        

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

        public class MyDiskInfos : IMyFree, IMyTotal
        {
            List<string> GetDisk;
            public MyDiskInfos()
            {
                GetDisk = Directory.GetLogicalDrives().ToList();
            }

            public string TotalSpace(string name)
            {
               var i = GetDisk.Where(x => x.ToLower()[0] == name.ToLower()[0]);
                if (i.Count() > 0)
                {
                    var i1 = i.ToArray()[0];
                    DriveInfo di = new DriveInfo(i1.ToString());

                    return di.TotalSize.ToString();
                }


                return "None driwer";
            }

            public string FreeSpace(string name)
            {
                var i = GetDisk.Where(x => x.ToLower()[0] == name.ToLower()[0]);
                if (i.Count() > 0)
                {
                    var i1 = i.ToArray()[0];
                    DriveInfo di = new DriveInfo(i1.ToString());

                    return di.TotalFreeSpace.ToString();
                }
                return "None driwer";
            }
        }


    }
}
