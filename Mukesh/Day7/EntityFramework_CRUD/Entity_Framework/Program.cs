using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();
            //Employee emp = new Employee() { ID = 12,Name="Nilesh",Salary=30000,Studio="Process Automation" };
            //data.Employees.Add(emp);

            int choice = 0;
            int salary, updatePara;
            string name, studio;
            do
            {
                Console.WriteLine("Enter 1 to insert items");
                Console.WriteLine("Enter 2 to Update items");
                Console.WriteLine("Enter 3 to Delete items");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter the name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the Salary:");
                        salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Studio name:");
                        studio = Console.ReadLine();
                        data.Database.ExecuteSqlCommand("Employee_Insert @Name , @Salary, @Studio",
                        new SqlParameter("@Name", name),
                        new SqlParameter("@Salary", salary),
                        new SqlParameter("@Studio", studio));
                        data.SaveChanges();
                        break;
                    case 2:
                        Console.WriteLine("enter the ID to update:");
                        updatePara= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the name to update:");
                        name= Console.ReadLine();
                        Console.WriteLine("enter the salary to update:");
                        salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the studio to update:");
                        studio = Console.ReadLine();
                        data.Database.ExecuteSqlCommand("Employee_Update  @ID, @Name, @Salary, @Studio",
                        new SqlParameter("@ID", updatePara),
                        new SqlParameter("@Name", name),
                        new SqlParameter("@Salary", salary),
                        new SqlParameter("@Studio", studio));
                        data.SaveChanges();
                        break;
                    case 3:
                        Console.WriteLine("enter the ID to update:");
                        updatePara = Convert.ToInt32(Console.ReadLine());
                        data.Database.ExecuteSqlCommand("Employee_Delete  @ID",
                        new SqlParameter("@ID", updatePara));
                        data.SaveChanges();
                        break;
                    default:
                        break;
                }

            } while (choice!= 0);
            
            Console.ReadKey();
        }


        public void Update()
        {

        }
        
    }
}
