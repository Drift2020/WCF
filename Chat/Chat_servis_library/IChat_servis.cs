using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Chat_servis_library
{

    //[ServiceContract]
    //public interface IChat_servis
    //{
    //    [OperationContract]
    //    int DoWork(int x, int y);
    //}

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChat_servis" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IServerChat))]
    public interface IChat_servis
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void Send_Message(string ms, int id);
    }

    public interface IServerChat
    {
        [OperationContract(IsOneWay = true)]
        void Message_Calback(string ms);
    }
}
