using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Chat_servis_library
{
    //public class Chat_servis : IChat_servis
    //{
    //    public int DoWork(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Chat_servis" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Chat_servis : IChat_servis
    {
        List<ServerUser> servers_Users = new List<ServerUser>();
        int next_id = 1;
        public int Connect(string name)
        {
            ServerUser tempUser = new ServerUser()
            {
                Id = next_id,
                Name = name,
                operationContext = OperationContext.Current
            };
            next_id++;
            Send_Message(tempUser.Name + " connect to chat", 0);
            servers_Users.Add(tempUser);
            return tempUser.Id;
        }

        public void Disconnect(int id)
        {
            var user = servers_Users.FirstOrDefault(i => i.Id == id);
            if (user != null)
            {
                servers_Users.Remove(user);
                Send_Message(user.Name + " disconnect to chat", 0);
            }

        }



        public void Send_Message(string ms, int id)
        {
            servers_Users.ForEach(elem =>
            {
                string send = DateTime.Now.ToShortTimeString();

                var user = servers_Users.FirstOrDefault(i => i.Id == id);
                if (user != null)
                {
                    send += ": " + user.Name + " ";
                }
                send += ms;

                elem.operationContext.GetCallbackChannel<IServerChat>().Message_Calback(send);

            });
        }
    }
}
