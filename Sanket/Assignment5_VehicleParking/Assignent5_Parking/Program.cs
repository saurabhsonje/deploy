using System;

namespace Assignent5_Parking
{

    class Program
    {
        static void Process(BaseVehicle vehicle) 
        {
            int c = 0;
            do
            {
                Console.WriteLine("Enter hour duration of parking: ");
                vehicle.GShourstatus = Convert.ToInt32(Console.ReadLine());
                vehicle.CalculatePCharge();
                Console.WriteLine("Enter 1 to recalculate hours or else to return to previous: ");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c == 1);
        }
        
        static void Main(string[] args)
        {
            //Car b = new Car();
            //b.GShourstatus = 6;
            //b.CalculatePCharge();
            //b.Run();
            //Console.WriteLine(b.GShourstatus);

            Console.WriteLine("Parking Vehicle: Which vehicle do you have\n enter 1: Car 2: Bike 3:SUV 4: Truck, \t -1 to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != -1)
            {
                
                if (choice >= 1 || choice <= 4)
                {
                    switch (choice)
                    {
                        case 1:
                            Car carobj = new Car();
                            Process(carobj);
                            break;
                        case 2:
                            Bike bobj = new Bike();
                            Process(bobj);
                            break;

                        case 3:
                            SUV sobj = new SUV();
                            Process(sobj);
                            break;
                        case 4:
                            Truck tobj = new Truck();
                            Process(tobj);
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine("Parking Vehicle: Which vehicle do you have\n enter 1: Car 2: Bike 3:SUV 4: Truck, \t -1 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
