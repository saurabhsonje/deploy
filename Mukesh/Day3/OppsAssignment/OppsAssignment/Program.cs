using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string Continue;
            List<Customer> custList = new List<Customer>();
            Bank b = new Bank();
            Customer cust = new Customer();
            
            do
            {
                Console.WriteLine("Enter 1 to enter customer details:");
                Console.WriteLine("Enter 2 to display customer details");
                Console.WriteLine("Enter 3 to search Customer by name");
                Console.WriteLine("Enter 4 to search Customer by Email ");

                choice =Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the name of customer");
                        cust.CustName = Console.ReadLine();
                        Console.WriteLine("Enter the ID of customer");
                        cust.CustId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the Email of customer");
                        cust.CustEmail = Console.ReadLine();
                        Console.WriteLine("Enter the salary of customer");
                        cust.CustSalary = Convert.ToInt16(Console.ReadLine());
                        cust.customerDetailsWithaccount();
                        custList.Add(cust);
                        break;
                    case 2:
                            Console.WriteLine("Enter the Name of customer to display details:");
                            string dispDetail = Console.ReadLine();
                            var dName = custList.Where(x => x.CustName == dispDetail).FirstOrDefault();
                            if (dName.CustName == dispDetail)
                            {
                            if(Custo)
                                Console.WriteLine("/nCustomer found by name {0}  and here is details:", dispDetail);
                                b.ShowDetails(cust);
                                Console.WriteLine("Total amount in account:"+Savingccount.Balance);

                        }
                        else
                            {
                                throw new Exception("Customer doesn't Exist");
                            }
                            break;
                    case 3:
                        Console.WriteLine("Enter the Email of customer to display:");
                        string dispcustDetail = Console.ReadLine();
                        var cName = custList.Find(x => x.CustName == dispcustDetail);
                        if (cName.CustName == dispcustDetail)
                        {
                            Console.WriteLine("Customer found by name {0}  and here is details:", dispcustDetail);
                            b.ShowDetails(cust);
                        }
                        else
                        {
                            throw new Exception("Customer doesn't Exist");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the Email of customer to display:");
                        string dispDetailByEmail = Console.ReadLine();
                        var email = custList.Find(x => x.CustEmail == dispDetailByEmail);
                        if (email.CustEmail == dispDetailByEmail)
                        {
                            Console.WriteLine("Customer found by Email {0}  and here is details:", dispDetailByEmail);
                            b.ShowDetails(cust);
                        }
                        else
                        {
                            throw new Exception("Customer doesn't Exist");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter the valid Option:");
                        break;
                }

                     Console.Write("\nDo You Want To Continue with customer operations? (Y/N) : ");
                     Continue = Console.ReadLine();
            } while (Continue != "N" && Continue != "n");

            Console.ReadKey();
        }
    }
}
