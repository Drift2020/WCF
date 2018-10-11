using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace DFv2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
       
       public string TotalSpace(string name)
        {
            foreach (var item in DriveInfo.GetDrives())
            {
                if (item.Name.ToLower().Contains(name.ToLower()[0])){
                    return item.TotalSize.ToString();
                }
            }
            return "none";
        }

        public string FreeSpace(string name)
        {
            foreach (var item in DriveInfo.GetDrives())
            {
                if (item.Name.ToLower().Contains(name.ToLower()[0]))
                {
                    return item.TotalFreeSpace.ToString();
                }
            }
            return "none";
        }
    }
}
