using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class TextMsg
    {
        public void sendMsg(string msg)
        {
            Console.WriteLine($"Message sent {msg}");
        }

        public void subscribe(Publisher program)
        {
            program.notification += sendMsg;
           
            Console.WriteLine("subscribed to texts");
        }
    }
}
