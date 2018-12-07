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
            int choice, a, b;
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
                            Console.WriteLine("Enter 1st number");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            b = int.Parse(Console.ReadLine());
                            op.Add(a, b);
                            //Console.WriteLine(op.Add(a, b));
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
                            Console.WriteLine("Enter 1st number");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            b = int.Parse(Console.ReadLine());
                            
                            if (a < b)
                            {
                                log.Error(new UserDefinedExceptions("Number must be greater"));
                            }

                        }
                        catch (FormatException e)
                        {
                            log.Error(e);
                            Console.WriteLine("not a number");
                        }

                        break;

                    case 3:                       
                        Console.WriteLine("Performing Divison");
                        Console.WriteLine("Enter 1st number");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2nd number");
                        b = int.Parse(Console.ReadLine());
                        if (b == 0)
                        {
                            throw new DivideByZeroException();
                        }

                        break;


                }
            }
            while (choice!=3);
        }
    }
}
