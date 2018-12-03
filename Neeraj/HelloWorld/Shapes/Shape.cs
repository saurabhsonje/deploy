using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
           
                Console.WriteLine("1. Triangle 2.Rectangle 3.Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1: Triangle shape = new Triangle();
                            shape.draw();
                            shape.print();
                            break;

                    case 2: Rectangle shape1 = new Rectangle();
                            shape1.draw();
                            shape1.print();
                            break;

                    case 3: break;
                }

            } while (choice != 3);
          //  Console.ReadKey(true);

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }


    }
}

