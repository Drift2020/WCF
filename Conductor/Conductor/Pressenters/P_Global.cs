using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Conductor
{
    class P_Global
    {
        FileInfo fi;
        private readonly I_Global _viwe;
        private readonly Histori model;
        
        //  private readonly 
        public P_Global(I_Global viwe)
        {

          
           if( !Directory.Exists("temp"))
           {
                Directory.CreateDirectory("temp");
           }
            //temp.ToList().ForEach(x =>
            //{
            //    if()
            //});
          


            model = new Histori();
            _viwe = viwe;
            _viwe.Close_Program += new EventHandler<EventArgs>(Close_Program);
            _viwe.Open_Tree += new EventHandler<EventArgs>(Open_Tree);
            _viwe.Close_Tree += new EventHandler<EventArgs>(Close_Tree);
            _viwe.Open_Folder_in_Tree += new EventHandler<EventArgs>(Open_Folder_in_Tree);
            _viwe.Edit_List_Viwe += new EventHandler<EventArgs>(Edit_List_Viwe);
            _viwe.Up += new EventHandler<EventArgs>(Up);
            _viwe.End += new EventHandler<EventArgs>(End);
            _viwe.Move_ += new EventHandler<EventArgs>(Move_);
            _viwe.Connect += new EventHandler<EventArgs>(Start_program);
            _viwe.Renewal += new EventHandler<EventArgs>(Renewal);
            _viwe.Remove_Die_Path += new EventHandler<EventArgs>(Remove_Die_Path);
            _viwe.ViweItem += new EventHandler<EventArgs>(ViweItem);
            _viwe.OpenFile+= new EventHandler<EventArgs>(Open_File);

        }

       
        public void Open_File(object sender, EventArgs e)
        {
         
           string[] file_temp = Directory.GetFiles("temp\\");

           if(file_temp.Length>0)
            file_temp.ToList().ForEach(x => { File.Delete(x); });

            _viwe.Select_Elements.ForEach(x =>
            {

            FileInfo temp_file = _viwe.proxy.GetFileInfo(x);



             

                if (temp_file.Attributes != FileAttributes.Directory && _viwe.proxy.StartStream(temp_file.FullName))
                {
                    byte[] file = null;

                    FileStream stream = File.Open("temp\\" + temp_file.Name, FileMode.Create);

                    var i = 5000;
                    while (_viwe.proxy.GetSize() > 0)
                    {
                        if (_viwe.proxy.GetSize() - i >= 0)
                            file = _viwe.proxy.GetStream(i);
                        else
                        {
                            file = _viwe.proxy.GetStream((int)_viwe.proxy.GetSize());
                        }

                       

                        stream.Write(file, 0, file.Length);

                        
                    }
                    stream.Dispose();
                    stream.Close();

                    var proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = "temp\\" + temp_file.Name;
                    proc.StartInfo.UseShellExecute = true;
                    proc.Start();

                }

            });


        }



        public void Remove_Die_Path(object sender, EventArgs e)
        {
            model.Dell_Histori_element(model.Now_Histori());
        }
        public void Close_Program(object sender, EventArgs e)
        {

        }  
        public void ViweItem(object sender, EventArgs e)
        {
            if(_viwe.NameItem== "ToolStripMenuItem1")
            {

            }
            else if(_viwe.NameItem == "ToolStripMenuItem2")
            {
                //




            }
            else if (_viwe.NameItem == "ToolStripMenuItem3")
            {

            }
            else if (_viwe.NameItem == "ToolStripMenuItem4")
            {

            }
        }

        #region Tree
        public void Close_Tree(object sender, EventArgs e)
        {
            model.Dell_Tree(_viwe.Full_Path_Note);
        }
        public void Open_Tree(object sender, EventArgs e)
        {
         
           
            string[] str = _viwe.proxy.GetDirectories((@"" + _viwe.Full_Path_Note), "*.*");


            model.Add_Tree(_viwe.Full_Path_Note);
            

            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                 
                 
                    fi = _viwe.proxy.GetFileInfo(str[i]);
                  
                    string[] str2 = _viwe.proxy.GetDirectories((@"" + fi.FullName), "*.*");
                    _viwe.Name_Notee_List.Add(fi.Name);
                    _viwe.Full_Path_Note_List.Add(fi.FullName);

                    if (str2.Length > 0)
                    {
                        _viwe.Name_Notee_element_List.Add(1);
                    }
                    else
                        _viwe.Name_Notee_element_List.Add(0);
                }
                catch (Exception ex)
                {

                };
            }
        }
        public void Open_Folder_in_Tree(object sender, EventArgs e)
        {
            
            model.Add_Histori(_viwe.Full_Path_Note.Replace("\\\\", "\\"));

            string temp = _viwe.Full_Path_Note.Replace("\\\\", "\\");
            //GetDirectories((@"" + _viwe.Full_Path_Note), "*.*");
            string[] str1 = _viwe.proxy.GetDirectories(@"" + temp, "*.*");
            //GetFiles((@"" + _viwe.Full_Path_Note), "*.*");
            string[] str2 = _viwe.proxy.GetFiles(@"" + temp, "*.*");
            int length = str1.Length;
            Array.Resize(ref str1, str1.Length + str2.Length);
            Array.Copy(str2, 0, str1, length, str2.Length);


            Info(str1);
            _viwe.str = str1;

        }
        public void Edit_List_Viwe(object sender, EventArgs e)
        {

        }
        #endregion Tree

        //g - LogicalDrives

        //это в службу
        private void Info(string[] str1)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                //GetFileInfo(str[i]);
                fi = _viwe.proxy.GetFileInfo(str1[i]);
                try
                {
                  
                    _viwe.Date_Edit_element_List.Add(fi.LastWriteTimeUtc.ToString());                                     
                }
                catch
                {
                    _viwe.Date_Edit_element_List.Add("");                   
                }
                try
                {
                    //GetFileAttributes( path);
                    _viwe.Type_element_List.Add(_viwe.proxy.GetFileAttributes(str1[i]).ToString());                   
                }
                catch
                {                
                    _viwe.Type_element_List.Add("");                  
                }
                try
                {
                    _viwe.Size_element_List.Add(fi.Length.ToString());
                }
                catch
                {               
                    _viwe.Size_element_List.Add("none");
                }
            }
        }
        public void Up(object sender, EventArgs e)
        {

            string _temp;
            string temp = _temp = model.Now_Histori();
            string[] str1;
            string[] str2;
            if ("none" != temp)
            {
                if(temp != "g")
                {
                    int i = temp.LastIndexOf('\\');
                    if(temp.Length-1==i)
                    {
                        temp = temp.Substring(0, i);
                    }
                    else
                    {
                        temp = temp.Substring(0, i);
                        if (temp[temp.Length - 1] == ':')
                            temp += '\\';
                    }
                   
                }

                ////// ////// ////// ////// ////// ////// ////// //////
                if (temp == "g")
                {
                    //GetLogicalDrives();
                    str1 = _viwe.proxy.GetLogicalDrives();
                }
                else if (temp[temp.Length - 1] == ':')
                {
                    //GetLogicalDrives();
                    str1 = _viwe.proxy.GetLogicalDrives();
                    temp = _temp;
                }
                else
                {
                    //GetDirectories((@"" + _viwe.Full_Path_Note), "*.*");
                    str1 = _viwe.proxy.GetDirectories(@"" + temp, "*.*");
                    //GetFiles((@"" + _viwe.Full_Path_Note), "*.*");
                    str2 = _viwe.proxy.GetFiles(@"" + temp, "*.*");

                    int length = str1.Length;

                    Array.Resize(ref str1, str1.Length + str2.Length);
                    Array.Copy(str2, 0, str1, length, str2.Length);

                }
                Info(str1);

                ////// ////// ////// ////// ////// ////// ////// //////
                _viwe.str = str1;
                model.Add_Histori(temp);
            }
            else
            {
                _viwe.str = null;
            }
        }
        public void End(object sender, EventArgs e)
        {
            string _temp;
            string temp = _temp = model.Back_Histori();
          
            string[] str1;
            string[] str2;
            if ("none" != temp)
            {
               


                if (temp == "g")
                {
                    str1 = _viwe.proxy.GetLogicalDrives();
                }
             
                else
                {
                    str1 = _viwe.proxy.GetDirectories(@"" + temp, "*.*");
                    str2 = _viwe.proxy.GetFiles(@"" + temp, "*.*");

                    int length = str1.Length;

                    Array.Resize(ref str1, str1.Length + str2.Length);
                    Array.Copy(str2, 0, str1, length, str2.Length);

                  
                }
                Info(str1);
                _viwe.str = str1;
               
            }
            else
            {
                _viwe.str = null;
            }
        }
        public void Move_(object sender, EventArgs e)
        {
            string _temp;
            string temp = _temp = model.Move_Histori();
            string[] str1;
            string[] str2;
            if ("none" != temp)
            {
                


                if (temp == "g")
                {
                    str1 = _viwe.proxy.GetLogicalDrives();
                }             
                else
                {
                    str1 = _viwe.proxy.GetDirectories(@"" + temp, "*.*");
                    str2 = _viwe.proxy.GetFiles(@"" + temp, "*.*");

                    int length = str1.Length;

                    Array.Resize(ref str1, str1.Length + str2.Length);
                    Array.Copy(str2, 0, str1, length, str2.Length);
                }
                Info(str1);
                _viwe.str = str1;
            }
            else
            {
                _viwe.str = null;
            }
        }

        //это в службу
        public void Start_program(object sender, EventArgs e)
        {

            try {

             
                _viwe.httpAdr1 = new EndpointAddress("http://"+ _viwe.ip +":"+ _viwe.port+ "/Library_Conductor");
                _viwe.HttpBinding = new BasicHttpBinding();
                _viwe.proxy = new Library_ConductorClient(_viwe.HttpBinding, _viwe.httpAdr1);


              
            string[] str1 = _viwe.proxy.GetLogicalDrives();
                int length = str1.Length;
            _viwe.str = str1;




            ////////////////////////////////////
          



                string[] astrLogicalDrives = _viwe.proxy.GetLogicalDrives();

                foreach (string disk in astrLogicalDrives)
                _viwe.Name_Notee_List.Add(disk);
            string[] str = null;
            for (int element = 0; element < astrLogicalDrives.Length; element++)
            {
                try
                {
                     
                        str = _viwe.proxy.GetDirectories((@"" + astrLogicalDrives[element]), "*.*");
                        if (str.Length > 0)
                    {
                        _viwe.Name_Notee_element_List.Add(1);
                    }
                    else
                        _viwe.Name_Notee_element_List.Add(0);
                }
                catch
                {
                    _viwe.Name_Notee_element_List.Add(0);
                }
            }
            Info(str1);

            model.Add_Histori("g");
            }
            catch { }
        }
      

        public void Renewal(object sender, EventArgs e)
        {
           
            for (string s = model.Move_Tree(); s != "none"; s = model.Move_Tree())
            {
                _viwe.Name_Notee_element_List_Tree.Add(s);
                string[] str = _viwe.proxy.GetDirectories((@"" +s ), "*.*");
                FileInfo fi;

                for (int i = 0; i < str.Length; i++)
                {
                    try
                    {
                        fi = _viwe.proxy.GetFileInfo(str[i]);
                        string[] str2 = _viwe.proxy.GetDirectories((@"" + fi.FullName), "*.*");
                        _viwe.Name_Notee_List.Add(fi.Name);
                        _viwe.Full_Path_Note_List.Add(fi.FullName);

                        if (str2.Length > 0)
                        {
                            _viwe.Name_Notee_element_List.Add(1);
                        }
                        else
                            _viwe.Name_Notee_element_List.Add(0);
                    }
                    catch (Exception ex)
                    {

                    };
                }
            }

            string temp = model.Now_Histori().Replace("\\\\", "\\");
            string[] str1, str3;
            if (temp == "g")
            {
                str1 = _viwe.proxy.GetLogicalDrives();
            }
            else
            {
                str1 = _viwe.proxy.GetDirectories(@"" + temp, "*.*");
                str3 = _viwe.proxy.GetFiles(@"" + temp, "*.*");

                int length = str1.Length;

                Array.Resize(ref str1, str1.Length + str3.Length);
                Array.Copy(str3, 0, str1, length, str3.Length);
            }
            _viwe.str = str1;



        }
    }
}

