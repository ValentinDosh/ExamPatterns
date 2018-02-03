using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new ChatMessenger();
            var alexandr = new Participant(chatroom, "Александр");
            var victor = new Participant(chatroom, "Виктор");
            var andrei = new Participant(chatroom, "Андрей");

           
            alexandr.SendChat("Всем привет)");
            Console.WriteLine();
            victor.PrivateMessage("Привет Андрей, ну как ты там?", "Андрей");

            Console.ReadKey();
        }
    }
}
