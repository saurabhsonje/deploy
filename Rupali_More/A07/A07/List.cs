using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07
{
    public class Customer_info
    {
        public string name;
        public int number;
        public string address;
        public Customer_info()
        {

        }
        public Customer_info(string n, int no, string ad)
        {
            name = n;
            number = no;
            address = ad;
        }
        public void GetInfo()
        {
            Console.WriteLine("Enter employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter employee Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee Name");
            address = Console.ReadLine();


        }
        public override string ToString()
        {
            return "name\t:" + name + "\tNumber\t:" + number.ToString() + "\tAddress\t:" + address;
        }
    }
    public class ListOpration
    {
        Customer_info c = new Customer_info();
        public List<Customer_info> cust = new List<Customer_info>();
        public void AddListElement(Customer_info c)
        {
            cust.Add(new Customer_info(c.name, c.number, c.address));
            cust.Add(new Customer_info("Rupali", 3, "shahada"));
            display_list();
        }
        public void DeleteListElement(Customer_info c)
        {
            Console.WriteLine("Enter name of customer which you want to delete");
            string Aname = Console.ReadLine();
            var cust1 = cust.Where(a => a.name == Aname).FirstOrDefault();
            cust.Remove(cust1);

            Console.WriteLine("Dispaying updated list");
            display_list();
        }
        public void UpdateListElement()
        {
            Console.WriteLine("Enter name of customer which you want to update");
            string Aname = Console.ReadLine();
            Console.WriteLine("Enter new info");
            string Nname = Console.ReadLine();
            foreach (var c in cust)
            {
                if (c.name == Aname)
                {
                    c.name = Nname;
                }
            }

            Console.WriteLine("Dispaying updated list");
            display_list();
        }
        public List<Customer_info> sortElement()
        {
            return cust.OrderBy(x => x.name).ToList();

        }
        public void display_list()
        {
            foreach (var i in cust)
            {
                Console.WriteLine(i);
            }
        }
    }
}
