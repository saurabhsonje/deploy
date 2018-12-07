using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignments
{
    class Program
    {
        private static readonly ILog Log =
             LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            int a=0, b=0;
            Calculation cal = new Calculation();
            int ch;
            char choice;
            do
            {
               
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("3.Division");
                Console.WriteLine("Enter Your Choice");
                ch = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("Enter element on which Operation are Performed");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    if ((a <0) || (b < 0))
                    {
                       
                        throw new ExceptionHandling("Enter Number greater than Zero");
                    }
                    
                
               
                switch (ch)
                    {
                        case 1:
                            int resultAdd = cal.Add(a, b);
                            Console.WriteLine("Addition is " + resultAdd);
                            break;
                        case 2:
                            int resultSub = cal.Sub(a, b);
                            Console.WriteLine("Subtraction is " + resultSub);
                            break;
                        case 3:
                            int resultMul = cal.Multiplication(a,b);
                            if (resultMul == 0)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Multiplication is " + resultMul);
                            }
                            break;
                        case 4:
                            try
                            {
                                if (a == 0 || b == 0)
                                {
                                    throw new ExceptionHandling("Divide By Zero Error");
                                }
                            }
                            catch(ExceptionHandling exe)
                            {
                                Log.Error(exe.Message);
                                Console.WriteLine(exe.Message);
                            }
                            int resultDiv = cal.Division(a,b);
                                Console.WriteLine("Division is " + resultDiv);
                            
                            break;
                    }
                }

                catch (ExceptionHandling exe)

                {
                    Log.Error(exe.Message);
                    Console.WriteLine(exe.Message);
                }
                catch (Exception exe)
                {
                    Log.Error("Enter Integer Value Only");
                    Console.WriteLine("Enter Integer Value Only");
                }

               
                Console.WriteLine("Do You Want To Continue");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice.Equals('Y') || choice.Equals('y'));

        }
    }
}
