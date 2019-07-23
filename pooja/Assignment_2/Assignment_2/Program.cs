using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle obj = new Circle();
            // obj.CalculateArea();


            Circle obj1 = new Circle(2);
            obj1.CalculateArea();

            Employee e = new Employee();
            Console.WriteLine("FullName=={0}", e.FullName());

            Employee emp = new Employee("Pooja", "Yerva");
            Console.WriteLine("fullName=={0}", emp.FullName());

            Console.ReadLine();
        }

    }

    public class Circle
    {
        static float _Pi;
        int _Radius;



        static Circle()
        {
            Console.WriteLine("from Static Constructor");
            _Pi = 3.141F;
        }

        public Circle()
        {
            Console.WriteLine("From Default Constructor");
        }

        public Circle(int radius)
        {
            Console.WriteLine("From Paramaterized Constructor");
            this._Radius = radius;
        }


        public void CalculateArea()
        {

            float Area = this._Radius * this._Radius * Circle._Pi;
            Console.WriteLine("area {0}", Area);
        }

        ~Circle()
        {
            // Destructor.
        }

    }

    public class Employee
    {
        string _FName;
        String _LName;


        public Employee() : this("FName", "LName")
        {

            Console.WriteLine("From Default Constructor from Employee");
        }

        public Employee(string FName, string LName)
        {
            Console.WriteLine("Parameterised Constructor From Employee");
            this._FName = FName;
            this._LName = LName;
        }

        public string FullName()
        {
            String Full_Name = this._FName + this._LName;
            return Full_Name;
        }


    }
}


