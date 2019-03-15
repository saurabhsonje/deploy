using System;


using ExtensionMethod;

public class Program
{
    public static void Main()
    {
        
        Console.Write("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool result = num.IsODD();

        Console.WriteLine("Result: {0}", result);
        Console.ReadLine();
    }
}
namespace ExtensionMethod
{
    public static class Extensions
    {
        public static bool IsODD(this int num)
        {
            return ((num % 2)!=0);
        }
    }
}
