using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay_1Assignment
{
    class Area_rectangle
    {
        public double lenght;
        public double height;

        public Area_rectangle()
        {
            //default constructor
            Console.WriteLine("program invoke in default constructor");
        }

        public Area_rectangle(double l_value,double h_value)
        {
            //Parameterized constructor
            lenght = l_value;
            height = h_value;
            Console.WriteLine("program invoke in parameterized constructor");
        }
        public double getArea()
        {
            return lenght * height;
        }
    }
    //static class
    static class Area_Square
    {
        //static data member
        public static double lenght_s=4.5;
        //static constructor
        static Area_Square()
        {
            Console.WriteLine("program invoke in staic constructor");
        }
        //static method
         public static double get_SquareArea()
        {
            return lenght_s * lenght_s; 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //calling default constructor
            Area_rectangle area = new Area_rectangle();

            //calling parameterized constructor
            Area_rectangle area1 = new Area_rectangle(4.5,6.7);
            Console.WriteLine("area of rectangle is:{0}",area1.getArea());
            //calling static method 
            Console.WriteLine("static class output:{0}",Area_Square.get_SquareArea());
            Console.ReadLine();
        }
    }
}
