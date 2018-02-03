using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger
{
    class ChatMessenger
    {
        List<Participant> _participants = new List<Participant>();

        public void AddPart(Participant participants)
        {
            _participants.Add(participants);
        }

        public void SendChat(string message, string from)
        {
            foreach (var colleague in _participants)
            {
                colleague.RecieveMessage(message, from);
            }
        }

        public void PrivateMessage(string message, string from, string to)
        {
            foreach (var colleague in _participants)
            {
                colleague.RecievePrivateMessage(message, from, to);
            }
        }
    }
}
