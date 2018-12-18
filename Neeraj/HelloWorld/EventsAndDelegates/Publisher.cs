using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Publisher
    {
        public delegate void Notification(string msg); // step 1: define delegate

        public event Notification notification;// step 2

        // should be outside any function so it can be accessed in another class directly

            public void PublishMsg(string abc)
        {
            notification.Invoke(abc);
        }


        /*     public  void Main1()
              {

                  int choice = 0;
                  Console.WriteLine("1.Text 2.Email");
                  choice = Convert.ToInt32(Console.ReadLine());

                  switch (choice)
                  {
                      case 1: TextMsg txtmsg = new TextMsg();
                              Publisher prog = new Publisher();
                              txtmsg.subscribe(prog);
                              notification.Invoke(" To Neeraj");
                              break;
                      case 2:
                          Email email = new Email();
                          Publisher prog1 = new Publisher();
                          email.subscribe(prog1);
                          notification.Invoke(" To Akash");
                          break;
                  }

                  // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
              }
              */



    }

    

}
