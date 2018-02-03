using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger
{
    class Participant
    {
        private ChatMessenger _chat;
        private string _name;

        public Participant(ChatMessenger chatName, string name)
        {
            _chat = chatName;
            _name = name;
            _chat.AddPart(this);
        }

        public void SendChat(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            _chat.SendChat(message, _name);
        }

        public void PrivateMessage(string message, string toName)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            _chat.PrivateMessage(message, _name, toName);
        }

        public  void RecieveMessage(string message, string from)
        {
            if (_name != from)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}", _name, from, message);
            }
        }

        public void RecievePrivateMessage(string message, string from, string to)
        {
            if (_name == to)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}", _name, from, message);
            }
        }
    }
}
