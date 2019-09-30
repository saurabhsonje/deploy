using System;
using EmployeeGenerics;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeGenerics
{
    public class CRUD_Op<T> : Employee<Object>
    {
        public List<T> elist;
        public void Insert(T E)
        {
            try
            {
                elist.Add(E);
                Console.WriteLine("Employee added successfully");
            }
            catch { throw new UserException("Employee Not added"); }
        }

        public void Remove(T E)
        {
            try
            { 
                elist.Remove(E);
                Console.WriteLine("Employee removed successfully");
            }
            catch { throw new UserException("Employee Not removed"); }
        }


        public void Display()
        {
            foreach (T item in elist)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public CRUD_Op()
        {
            elist = new List<T>();
        }
    }
    class Program
    {
        static void Add(CRUD_Op<Employee<Object>> op) 
        {
            int age = 0;
            double salary = 0;
            Console.WriteLine("Enter Employee details");
            Console.WriteLine("Enter Employee name");
            String name = Console.ReadLine();
            
            Console.WriteLine("Enter Employee age");
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine(new UserException("Invalid ID"));
            }
            //int.Parse( Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Employee salary");
            if (!double.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine(new UserException("Invalid Salary"));
            }
            
            Console.WriteLine("Enter Employee designation");
            String desg = Console.ReadLine();
            if (name != "" && age > 0 && salary > 0 && desg != "")
            {
                Employee<Object> emp = new Employee<Object>(name,age,salary,desg);
                emp.PropertyId = op.elist.Count + 1;
                op.Insert(emp);
            }
        }
        static void Delete(CRUD_Op<Employee<Object>> op, int id) 
        {
            Employee<Object> edel = new Employee<object>();
            foreach (var item in op.elist)
            {
                if ((int)item.PropertyId == id)
                    edel = item;
            }
            if (edel != null)
                op.Remove(edel);    
        }
        static void Main(string[] args)
        {
            Employee<Object> e = new Employee<Object>("Sanket", 25, 25000, "Developer");
            CRUD_Op<Employee<Object>> op = new CRUD_Op<Employee<Object>>();

            Console.WriteLine("Employee Register: \n enter 1: New Employee 2: Terminate Employee 3:Display Employee details \t -1 to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != -1)
            {

                if (choice >= 1 || choice <= 3)
                {
                    switch (choice)
                    {
                        case 1:
                            Add(op);
                            break;
                        case 2:
                            Console.WriteLine("Enter Employee Id to terminate");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Delete(op, id);
                            break;

                        case 3:
                            op.Display();
                            break;
                        
                        default:
                            break;
                    }
                }
                Console.WriteLine("Employee Register: \n enter 1: New Employee 2: Terminate Employee 3:Display Employee details \t -1 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            //e.print();
            //op.Insert(e);
            //op.Insert(e);
            //op.Display();
            //op.Remove(e);
            //op.Display();
            //Console.WriteLine(e.ToString());
            //Console.ReadLine();
        }
    }
}

