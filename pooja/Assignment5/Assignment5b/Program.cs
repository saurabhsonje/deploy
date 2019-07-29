using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5b
{
    class Program
    {
        static void Main(string[] args)
        {
            char Inputchoice = 'N';
            int InputFromUser = 0;
            DateTime date = DateTime.Now;
            Console.WriteLine(date);

           
            do
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1.DateWithDayPrefix");
                Console.WriteLine("2. DateWithFullDayPrefix");
                Console.WriteLine("3.DateWithTime");
                Console.WriteLine("4.DateTimeStamp");
                Console.WriteLine("5.DateJson");
                Console.WriteLine("6.DateTimeJson");
                Console.WriteLine("7.DateLocal");
                Console.WriteLine("Enter Your Choice....!!!");
                Console.WriteLine("---------------------");

                InputFromUser = Convert.ToInt32(Console.ReadLine());
                string date1 = date.DisplayDate(Convert.ToString(InputFromUser));
                Console.WriteLine(date1);

                Console.WriteLine("Do you want to continue(Y/N)");
                Inputchoice = Convert.ToChar(Console.ReadLine());

            } while (Inputchoice.Equals('Y') || (Inputchoice.Equals('y')));
            
           

            Console.ReadKey();
        }
    }
}



