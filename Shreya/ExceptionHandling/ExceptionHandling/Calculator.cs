using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ExceptionHandling
{
    class Calculator
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(String[] args)
        {
            int choice ,num1 , num2;
            Console.WriteLine("Enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Welcome to Calculator Application");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Divide");
               
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                Operations op = new Operations();

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Performing addition");
                            
                            op.Add(num1, num2);
                            
                            log.Info("Addition successfully");
                        }
                        catch (FormatException e)
                        {
                            log.Error(e);
                            Console.WriteLine("not a number");
                        }

                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Performing substraction");


                            if (num1 < num2)
                            {
                                log.Error(new UserDefinedExceptions("Number must be greater"));
                            }
                            else
                            {
                                
                                log.Info("Substraction successfully");
                            }

                        }
                        catch (FormatException e)
                        {
                            log.Error(e);
                            Console.WriteLine("not a number");
                        }

                        break;

                    case 3:

                        if (num2 == 0)
                        {
                            log.Error(new UserDefinedExceptions("Number must be non zero"));
                        }
                        else
                        {
                            Console.WriteLine("Divison is successful");
                        }

                        break;


                }
            }
            while (choice!=3);
        }
    }
}
