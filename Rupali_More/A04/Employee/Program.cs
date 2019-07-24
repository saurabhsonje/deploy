using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class employee_info
    {
        public int emp_id;
        public string emp_name;
        public string cmp_location;
        public string cmp_name;
        public employee_info(int e_id,string e_name,string e_cLocation,string e_cName)
        {
            this.emp_id = e_id;
            this.emp_name = e_name;
            this.cmp_location = e_cLocation;
            this.cmp_name = e_cName;
        }

        public override string ToString()
        {
          
            return "emp_id\t" +" " +emp_id + ": emp_name\t"+emp_name+ ": cmp_location\t"+cmp_location+ ": cmp_name\t"+cmp_name;
        }



    }
    class Genric_empInfo<T>
    {
        public List<T> info = new List<T>() ;
        public void display()
        {
            try
            {
                foreach (var i in info)
                {
                    Console.WriteLine(i);
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("exception occured");
            }
        }
        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
          
          //  employee_info info1 = new employee_info(2, "Rupali", "Pune", "Globant");
            Genric_empInfo<employee_info> obj1 = new Genric_empInfo<employee_info>();
            obj1.info.Add(new employee_info(2, "Rupali", "Pune", "Globant"));
            obj1.info.Add(new employee_info(3, "deepali", "Pune", "Globant"));
             
       
            obj1.info.Add(new employee_info(2, "pooja", "Pune", "Globant"));
            obj1.info.Add(new employee_info(2, "sonali", "Pune", "Globant"));
            obj1.display();

            obj1.info.RemoveAt(2);
            Console.WriteLine("element delete :)");
            obj1.display();
            
            Console.ReadKey();
        }
    }
}
