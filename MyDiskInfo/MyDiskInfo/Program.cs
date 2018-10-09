using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.ServiceModel.Channels;
using System.IO;
namespace MyDiskInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
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
              "net.tcp://localhost/MyDiskInfos/Ep1");

            CustomBinding MyBinding = new CustomBinding();
            MyBinding.Elements.Add(new TextMessageEncodingBindingElement());
            MyBinding.Elements.Add(new HttpTransportBindingElement());

            sh.AddServiceEndpoint(
              typeof(IMyTotal),
              MyBinding,
              "http://localhost:8084/MyDiskInfos/Ep2");

            sh.CloseTimeout = TimeSpan.FromSeconds(20); // время тайм-аута для блокирования клиента при вызове Close()
            sh.Open();
           
        ///    sh.Close();

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
               var i = GetDisk.Where(x => x[0] == name[0]);
                var i1 = i.ToArray()[0];
                DriveInfo di = new DriveInfo(i1.ToString());

                return di.TotalSize.ToString();
            }

            public string FreeSpace(string name)
            {
                var i = GetDisk.Where(x => x[0] == name[0]);
                var i1 = i.ToArray()[0];
                DriveInfo di = new DriveInfo(i1.ToString());

                return di.TotalFreeSpace.ToString();
            }
        }

    }
}
