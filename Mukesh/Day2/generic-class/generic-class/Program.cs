using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    public class Generic<T>
    {

        ArrayList al = new ArrayList();

        public void Add(T item)
        {
            al.Add(item);
        }

        public void Delete(int item)
        {
            al.RemoveAt(item);
        }

        public void showDetails()
        {
            foreach(T e in al)
            {
                Console.WriteLine("\n"+e.ToString());
            }
        }
    }

    public class Employee
    {

        public string Name { get; set; }
        public int ID { get; set; }
        public string Adress { get; set; }

        public override string ToString()
        {
            return ID.ToString()+" "+Name+" "+Adress;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int empDetail=0;
            Generic<Employee> g = new Generic<Employee>();
            do
            {
                try
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("1.Enter 1 to Add Employee Details:\n");
                    Console.WriteLine("2.Enter 2 to Delete Employee Details:\n");
                    Console.WriteLine("------------------------------------------");
                    empDetail = Convert.ToInt32(Console.ReadLine());
                    switch (empDetail)
                    {

                        case 1:
                            Employee emp = new Employee();
                            Console.Write("Enter the ID of employee you want to add:\n");
                            emp.ID = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Name of employee you want to add:\n");
                            emp.Name = Console.ReadLine();
                            Console.Write("Enter the Adress of employee you want to add:\n");
                            emp.Adress = Console.ReadLine();
                            g.Add(emp);
                            g.showDetails();
                            break;
                        case 2:
                            //Employee emp1 = new Employee();
                            Console.Write("Enter the Index(starting from 0) of employee you want to :\n");
                            int srNo = Convert.ToInt32(Console.ReadLine());
                            g.Delete(srNo);
                            g.showDetails();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excaption raised:{0}", e.Message);
                }
            }while(empDetail != 0) ;
            Console.ReadKey();
        }
    }
}
