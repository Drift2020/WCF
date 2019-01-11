using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Library_Conductor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Library_Conductor" in both code and config file together.



    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Library_Conductor : ILibrary_Conductor
    {
        FileStream fs;
        long Length = 0;
        public string[] GetDirectories(string path, string filt)
        {
            return Directory.GetDirectories(path, filt);
        }

        public FileAttributes GetFileAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        public FileInfo GetFileInfo(string path)
        {
            return new FileInfo(path);
        }

        public string[] GetFiles(string path, string filt)
        {
          return Directory.GetFiles(path, filt);
        }

        public string[] GetLogicalDrives()
        {
            return Directory.GetLogicalDrives();
        }

        public long GetSize()
        {
           return Length;
        }

      

        public byte[] GetStream(int size)
        {
            if (Length > size)
                Length -= size;
            else
            {
                size = (int)Length;
                Length = 0;
            }

                byte[] data = new byte[size];


                fs.Read(data, 0, (int)data.Length);
                return data;
           
        }

        public bool StartStream(string path)
        {
            if (fs != null)
            {
                fs.Dispose();
                fs.Close();
            }
            try
            {
                fs = new FileStream(path, FileMode.Open);
                Length = fs.Length;
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
