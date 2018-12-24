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
            
        int choice = 0,number1,number2;
            int result;
            do
            {
                Console.WriteLine("1.Add 2.Sub 3.Divide 4.Exit");
                string stringChoice = Console.ReadLine();
                bool input = Int32.TryParse(stringChoice,out choice);
                if (choice == 4)
                {
                    Console.WriteLine("Exiting..");
                }
                else
                {

                    if (input)
                    {

                        Console.WriteLine("Enter number 1");
                        //  number1 = Convert.ToInt32(Console.ReadLine());
                        bool num1 = Int32.TryParse(Console.ReadLine(), out number1);
                        Console.WriteLine("Enter number 2");
                        bool num2 = Int32.TryParse(Console.ReadLine(), out number2);

                        if (num1 & num2)
                        {
                            Operation op = new Operation();
                            switch (choice)
                            {
                                case 1:
                                    try
                                    {

                                        result = op.add(number1, number2);
                                        Log.Info("addition successful");
                                        Console.WriteLine("Addition successful {0}", result);

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

                                        if (number1 < number2)
                                        {

                                            Log.Error(new UserDefinedException("1st no cannot be greater than 2nd number"));
                                            ////2nd way of exception handling - userdefined exception
                                        }
                                        else
                                        {
                                            result = op.sub(number1, number2);
                                            Log.Info("Subtraction successful");
                                            Console.WriteLine("Subtraction successful {0}", result);
                                        }


                                    }

                                    catch (FormatException fe)
                                    {
                                        Log.Error(fe);
                                        // log4net.Appender.ColoredConsoleAppender("not a number");
                                        Console.WriteLine("Not a number");

                                    }


                                    break;

                                case 3:

                                    /*
                                     if (number2 == 0)
                                    {
                                        throw new DivideByZeroException(); ////3rd way of exception handling - throw keyword
                                    }

                                    */

                                    try
                                    {
                                        result = op.div(number1, number2);
                                        Log.Info("division successful");
                                        Console.WriteLine("Divisuon successful {0}", result);
                                    }
                                    catch (DivideByZeroException ex)
                                    {
                                        Log.Error(ex);
                                        Console.WriteLine("Number cannnot be divided by zero");
                                    }

                                    break;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Number 1 or 2 is cannot be converted to integer");
                        }
                    }


                    else
                    {

                        Console.WriteLine("Choice cannot be converted to a integer");
                    }

                } 
                
            } while (choice!=4);
            
            

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
