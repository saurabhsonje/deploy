using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExceptionHandling
{
    class Calculator
    {
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            
        int choice = 0,a,b;
            do
            {
                Console.WriteLine("1.Add 2.Sub 3.Divide");
                choice = Convert.ToInt32(Console.ReadLine());
                Operation op = new Operation();
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter number 1");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter number 2");
                            b = Convert.ToInt32(Console.ReadLine());
                            op.add(a, b);
                            Log.Info("addition successful");
                        }
                        catch (FormatException fe) //1st way of exception handling
                        {
                            Log.Error(fe);
                            Console.WriteLine("Not a number");

                        }

                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Enter number 1");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter number 2");
                            b = Convert.ToInt32(Console.ReadLine());

                            if (a < b)
                            {
                               
                                Log.Error(new UserDefinedException("1st no cannot be greater than 2nd number"));
                                ////1st way of exception handling - userdefined exception
                            }
                        }

                        catch(FormatException fe)
                        {
                            Log.Error(fe);
                            Console.WriteLine("Not a number");

                        }

                       
                        break;

                    case 3:
                        Console.WriteLine("Enter number 1");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number 2");
                        b = Convert.ToInt32(Console.ReadLine());

                        if (b == 0)
                        {
                            throw new DivideByZeroException(); ////3rd way of exception handling - throw keyword
                        }

                        break;

                }
            } while (choice!=3);
            
            

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
