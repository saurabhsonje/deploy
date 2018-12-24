using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            List<Product> products = new List<Product>();
            char ch;
            do
            {
                FileLogger log = new FileLogger();
                Console.WriteLine("1.Enquiry");
                Console.WriteLine("2.Check Discount As Per Type Of Customer");
                int choice;
                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        products= product.getAllProduct();
                        products.ForEach(x => Console.WriteLine(x.name+" "+x.price));
                        Console.WriteLine("Visited For The Fisrt Time");
                        log.handle("Logged in for first time");
                        break;
                    case 2:
                        Console.WriteLine("Enter Type Of Customer");
                        string customer = Console.ReadLine();
                        if(customer.Equals("Silver")||customer.Equals("silver"))
                        {
                           SilverCustomer silver = new SilverCustomer();
                           double discount=silver.getDiscount();
                           Console.WriteLine("Silver Customer Will Get this Discount " + discount);
                           log.handle("Silver Customer Will Get this Discount " + discount);
                        }
                        if(customer.Equals("Gold")||customer.Equals("gold"))
                        {
                            GoldCustomer gold = new GoldCustomer();
                            double discount = gold.getDiscount();
                            Console.WriteLine("Gold Customer Will Get this Discount " + discount);
                            log.handle("Gold Customer Will Get this Discount " + discount);
                        }
                        break;

                  

                }
                Console.WriteLine("Do You Want To Continue");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch.Equals('y') || ch.Equals('Y'));


        }
    }
    }