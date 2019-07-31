using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue;
            EmployeeDbContext data = new EmployeeDbContext();
                      
               int Choices;

            do
            {
                Console.WriteLine("Please select which operation you want to perform");
                Console.WriteLine("\n\n1.Insert\n2.Display\n3.Upadate\n4.Delete");
                Choices = int.Parse(Console.ReadLine());
                switch (Choices)
                {
                    case 1:                        
                        data.Database.ExecuteSqlCommand("insertEmployee @Name , @Salary", new SqlParameter("@Name", "ram"), new SqlParameter("@Salary", 120));
                        data.SaveChanges();
                        break;

                    case 2:
                        var a = data.employee.SqlQuery("ListEmployee").ToList();
                        foreach (var item in a)
                        {
                            Console.WriteLine(item);
                            Console.WriteLine("\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter id");
                        int Id = Convert.ToInt32(Console.ReadLine()) ;
                        Console.WriteLine("Enter Name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        var salary = Convert.ToInt32(Console.ReadLine());                        
                        EmployeeCodeFirst employeeResult = data.employee.FirstOrDefault(x => x.Id == Id);
                        employeeResult.Name = name;
                        employeeResult.Salary = salary;

                        var UpadateData = data.employee.SqlQuery("exec EmployeeCodeFirst_Update @ID ,@Name , @Salary", 
                            new SqlParameter("@Id", Id),
                            new SqlParameter("@Name", employeeResult.Name), 
                            new SqlParameter("@Salary", employeeResult.Salary));

                           data.SaveChanges();
                        Console.WriteLine("Done with update data");
                        break;

                    case 4:

                        Console.WriteLine("Enter id");
                        int Id1 = Convert.ToInt32(Console.ReadLine());
                        data.Database.ExecuteSqlCommand("EmployeeCodeFirst_Delete @Id", new SqlParameter("@Id", Id1));

                        data.SaveChanges();
                        break;
                }
                Console.WriteLine("do you want to continue y/n");
                Continue = Console.ReadLine();
            } while (Continue != "N" && Continue != "n");
        }
    }
}


