using System;

namespace Assignment06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int area = 0, len= 5, wid= 5;
            Console.WriteLine("value passing parameters :length: {0} and width: {1}", len, wid);
            //value type parameter
            Area(len, wid, area); 
            Console.WriteLine("After value method parameters :length: {0} , width: {1} and area: {2}", len, wid, area);

            int refarea = 0, reflen = 5, refwidth = 10;
            Console.WriteLine("\nref passing parameters :length: {0} and width: {1}", reflen, refwidth);

            Area(ref reflen, ref refwidth, ref refarea);

            Console.WriteLine("ref parameters after method: ");
            // Display the value length, width, and Rarea 
            System.Console.WriteLine("Length of the rectangle is: " + reflen);
            System.Console.WriteLine("Width of the rectangle is: " + refwidth);
            System.Console.WriteLine("Area of the rectangle is: " + refarea);

            // In-line declaraing out parameter without assigning values  
            OutArea(out int length, out int width, out int Rarea);

            Console.WriteLine("\nout parameters after method: ");
            // Display the value length, width, and Rarea 
            System.Console.WriteLine("Length of the rectangle is: " + length);
            System.Console.WriteLine("Width of the rectangle is: " + width);
            System.Console.WriteLine("Area of the rectangle is: " + Rarea);
            
            Console.WriteLine();
            Console.WriteLine("using out parameter for validating numeric input data \nPlease enter you age");
            //store result in out variable that provides the result if the method succeeds
            bool isValid = int.TryParse(Console.ReadLine(), out int age);
            string message = isValid ? $"You are {age} Years old" : "Please enter valid age";
            Console.WriteLine(message);
        }

        public static void Area(int len, int width, int Rarea)
        {
            len = 10;
            width = 20;
            Rarea = len * width;
            Console.WriteLine("In Area method parameters :length: {0} , width: {1} and area: {2}", len, width, Rarea);
        }
        public static void Area(ref int len, ref int width, ref int Rarea)
        {
            len = 10;
            width = 20;
            Rarea = len * width;
            Console.WriteLine("In Area method parameters :length: {0} , width: {1} and area: {2}", len, width, Rarea);
        }
        // Method in which out parameters are passed 
        public static void OutArea(out int len,out int width, out int Rarea)
        {
            //assigning values
            len = 30;
            width = 50;
            Rarea = len * width;
            Console.WriteLine("\nIn Area method out parameters :length: {0} , width: {1} and area: {2}", len, width, Rarea);
        }
    }

}

