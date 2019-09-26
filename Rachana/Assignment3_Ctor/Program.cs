using System;

namespace Assignment3_Ctor
{
    class Program
    {
        int redius;
        static float pi;

        static Program()    //static Constructor
        {
            pi = 3.14f;
        }
        public Program()  //default Constructor
        {
            redius = 35;

        }
        public Program(int r)  //Parameterized Constructor
        {
            redius = r;
        }
        public Program(Program program) //Copy Constructor
        {
            redius = program.redius;
        }

        public void calArea()
        {
            float area = pi * redius * redius;
            Console.WriteLine("Area of Circle:{0}", area);

        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.calArea();

            Program p2 = new Program(25);
            p2.calArea();

            Program p3 = new Program(p1);
            p3.calArea();

        }
    }
}
