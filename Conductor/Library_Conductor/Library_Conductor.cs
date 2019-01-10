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
    public class Library_Conductor : ILibrary_Conductor
    {
       

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

        public Stream GetStream(string path)
        {

            FileStream fs = new FileStream(path, FileMode.Open);        
            return fs;
        }
    }
}
