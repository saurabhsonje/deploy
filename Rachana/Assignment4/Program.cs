using System;
using System.Collections.Generic;

namespace Employee
{
    public class employee
    {
        public int emp_id;
        public string emp_name;
        public string emp_address;

        public employee(int id, string name, string address)
        {
            this.emp_id = id;
            this.emp_name = name;
            this.emp_address = address;
        }

        public override string ToString()
        {
           return "emp_id:" + emp_id + "\temp_name:" + emp_name + "\temp_address:" + emp_address;
        }
       
    }

    class Genric_employee<T>
    {
        public List<T> list = new List<T>();
        public void display()
        {
            try
            {
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException Occured");
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Genric_employee<employee> emp = new Genric_employee<employee>();

            emp.list.Add(new employee(1, "Rachana", "Sangli"));
            emp.list.Add(new employee(2, "Priyanka", "Pune"));
            emp.list.Add(new employee(3, "Supriya", "Mumbai"));

            emp.display();
            emp.list.RemoveAt(0);
            Console.WriteLine("Employee deleted");
            emp.display();

            Console.ReadKey();
        }
    }
}