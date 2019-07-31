using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodCompanyContext context = new FoodCompanyContext();


            var Company = new Company() { Company_Name = "Bill", Company_city = "pune" };
            var company1 = new Company() { Company_Name = "seema", Company_city = "mumbai" };
            context.companys.Add(Company);
            context.companys.Add(company1);
            context.SaveChanges();

            var food = new Food() { Item_Name = "sabudana", Item_Unit = "rs", Company_Id = 1,company=company1 };
            var food1 = new Food() { Item_Name = "soyabin", Item_Unit = "rs", Company_Id = 3 };
            context.foods.Add(food);
            context.foods.Add(food1);



            context.SaveChanges();
            //---------------Detail from two Related Table using  Store procedure---------------------                
            Console.WriteLine("Detail from two Related Table using  Store procedure\n");
            List<Mapping_Customer> result = context.mapping_customer.SqlQuery("MappingData").ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("Detail from two Related Table using  lambda expression\n");
            //---------------Detail from two Related Table using  lambda expression---------------------              
            var result1 = context.foods.Join(context.companys, f => f.Company_Id,
                        c => c.Company_Id, (f, c) => new { f.Item_Name });
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            var company_list= food.company.Company_Name.ToList();
            Console.ReadLine();
        }
    }
}

