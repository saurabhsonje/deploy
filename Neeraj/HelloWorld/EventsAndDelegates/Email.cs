using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Email
    {
        public void EmailSent(string msg)
        {
            Console.WriteLine($"Email sent {msg}");
        }
        public void subscribe(Publisher program)
        {
            program.notification += EmailSent;
            Console.WriteLine("subscribed to emails");
        }
    }
}
