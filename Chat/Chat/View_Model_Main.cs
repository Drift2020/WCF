using Chat.ServiceReference1;
using Chat_servis_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chat
{
    class View_Model_Main: View_Model_Base, IServerChat
    {

        public View_Model_Main()
        {
            Button = "Connect";
            IsEneble = true;
            
        }
        public void OnWindowClosing()
        {

        }
        #region data

        Chat_servisClient client;

        int ID;
      

 bool isEneble;
        public bool IsEneble
        {
            set
            {
                isEneble = value;
                OnPropertyChanged(nameof(IsEneble));
            }
            get
            {
                return isEneble;
            }
        }


        string button;
        public string Button
        {
            set
            {
                button = value;
                OnPropertyChanged(nameof(Button));
            }
            get
            {
                return button;
            }
        }


        string name;
        public string Name
        {
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
            get
            {
                return name;
            }
        }
        string ip;
        public string IP
        {
            set
            {
                ip = value;
                OnPropertyChanged(nameof(IP));
            }
            get
            {
                return ip;
            }
        }

        string port;
        public string PORT
        {
            set
            {
                port = value;
                OnPropertyChanged(nameof(PORT));
            }
            get
            {
                return port;
            }
        }

        string message;
        public string Message
        {
            set
            {
                message = value;
                OnPropertyChanged(nameof(Message));
            }
            get
            {
                return message;
            }
        }
        #endregion data

        bool isConnect = false;
      

        #region Connect
        private DelegateCommand _Command_Connect;
        public ICommand Button_clik_Connect
        {
            get
            {
                if (_Command_Connect == null)
                {
                    _Command_Connect = new DelegateCommand(Execute_Connect, CanExecute_Connect);
                }
                return _Command_Connect;
            }
        }
        private void Execute_Connect(object o)
        {
            if(isConnect)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }
        }
        private bool CanExecute_Connect(object o)
        {
           

            return true;
        }


        void ConnectUser()
        {
            if (!isConnect)
            {

              
                client = new Chat_servisClient(new System.ServiceModel.InstanceContext(this));

                ID = client.Connect(name);
                Button = "Disconnect";
                IsEneble = false;
                isConnect = true;
            }
        }
        public void DisconnectUser()
        {
            client.Disconnect(ID);
            client = null;
            Button = "Connect";
            IsEneble = true;
            isConnect = false;
        }
        #endregion Connect





        #region Send
        private DelegateCommand _Command_Send;
        public ICommand Button_clik_Send
        {
            get
            {
                if (_Command_Send == null)
                {
                    _Command_Send = new DelegateCommand(Execute_Send, CanExecute_Send);
                }
                return _Command_Send;
            }
        }
        private void Execute_Send(object o)
        {
            if(client!=null)
            client.Send_Message(message,ID);
            Message = "";
        }
        private bool CanExecute_Send(object o)
        {

            if(client!=null)
            return true;
            return false;
        }


        public void Message_Calback(string ms)
        {
            List_message.Add(ms);
        }

        #endregion Send



        List<string> list_message = new List<string>();
        public List<string> List_message
        {
            set
            {
                list_message = value;
                OnPropertyChanged(nameof(List_message));
            }
            get
            {
                return list_message;
            }
        }
    }
}
