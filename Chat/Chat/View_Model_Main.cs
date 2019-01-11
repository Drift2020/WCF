using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chat
{
    class View_Model_Main: View_Model_Base
    {
        #region data
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
         
        }
        private bool CanExecute_Connect(object o)
        {
           

            return false;
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

        }
        private bool CanExecute_Send(object o)
        {


            return false;
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
