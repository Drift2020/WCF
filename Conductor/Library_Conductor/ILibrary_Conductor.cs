using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library_Conductor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILibrary_Conductor" in both code and config file together.
    [ServiceContract]
    public interface ILibrary_Conductor
    {
     

        [OperationContract]
        string[] GetDirectories(string path, string filt);

        [OperationContract]
        string[] GetLogicalDrives();

        [OperationContract]
        FileInfo GetFileInfo(string path);

        [OperationContract]
        FileAttributes GetFileAttributes(string path);

        [OperationContract]
        string[] GetFiles(string path, string filt);

        [OperationContract]
        byte[] GetStream(int size);

        [OperationContract]
        bool StartStream(string path);

        [OperationContract]
        long GetSize();

    }
}
