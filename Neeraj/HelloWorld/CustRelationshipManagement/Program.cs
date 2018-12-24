using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustRelationshipManagement
{
    class Program 
    {
       
        static void Main(string[] args)
        {
            Enquiry enquiry = new Enquiry();
            enquiry.ProductList();
            int buyChoice, customerType, customerLogChoice;

            try
            {
                do
                {
                    Console.WriteLine("Do you want to buy an item? 1.Yes 2.No");
                    buyChoice = Int32.Parse(Console.ReadLine());

                    if (buyChoice == 1)
                    {
                        Console.WriteLine("Choose type of logging 1.Text Message 2.Email");
                        customerLogChoice = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("type of customer 1.Gold 2.Silver 3.ordinary");
                        customerType = Int32.Parse(Console.ReadLine());

                        switch (customerType)
                        {
                            case 1:
                                GoldCustomer goldCustomer = new GoldCustomer();
                                goldCustomer.GetCustomerType(); // inheritance from a class
                                goldCustomer.GetDiscount(); // inheritance from an interface
                                goldCustomer.setLoggin(customerLogChoice);
                                break;
                            case 2:
                                SilverCustomer silverCustomer = new SilverCustomer();
                                silverCustomer.GetCustomerType();
                                silverCustomer.GetDiscount();
                                silverCustomer.setLoggin(customerLogChoice);
                                break;
                            case 3:
                                Customer customer = new Customer();
                                customer.GetCustomerType();
                                customer.GetDiscount();
                                customer.setLoggin(customerLogChoice);
                                break;

                        }
                        Console.WriteLine("***User Logged Out*****");
                       

                    }
                    else
                    {
                        Console.WriteLine("You can just see the product list");
                    }
                } while (buyChoice != 2);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Wrong input format");
            }

            Console.ReadKey();
        }
    }
}
