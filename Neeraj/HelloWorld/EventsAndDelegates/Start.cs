using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Start
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Email email = new Email();
            TextMsg txtmsg = new TextMsg();
            email.subscribe(p);
            txtmsg.subscribe(p);
            p.PublishMsg("Hi there");
           // p.Main1();
        }

    }
}
