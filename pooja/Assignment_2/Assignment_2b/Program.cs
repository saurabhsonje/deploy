using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter Two Numbers a & b :");
                a = Convert.ToInt16(Console.ReadLine());
                b = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("a={0},b={1}", a, b);

                int res = a / b;
                Console.WriteLine("Result = {0}", res);

                throw new MyException("Pooja");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            //catch (Exception)
            //{
            //    Console.WriteLine("Exception");
            //}
            catch (Exception)
            {
                Console.WriteLine("Exception caught here");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.ReadLine();
        }

    }
    class MyException : Exception
    {
        public MyException(string str)
        {
            Console.WriteLine("User defined exception");
        }
    }
}


//System.OutOfMemoryException
//System.NullReferenceException
//Syste.InvalidCastException
//Syste.ArrayTypeMismatchException
//System.IndexOutOfRangeException
//System.ArithmeticException
//System.DevideByZeroException
//System.OverFlowException 