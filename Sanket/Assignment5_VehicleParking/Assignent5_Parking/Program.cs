using System;

namespace Assignent5_Parking
{

    class Program
    {
        static void Process(Car cvehicle) 
        {
            int c = 0;
            do
            {
                cvehicle.TakeParkingDuration();
                cvehicle.CalculatePCharge();
                Console.WriteLine("Enter 1 to recalculate hours or else to return to previous: ");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c == 1);
        }
        static void Process(Bike bvehicle)
        {
            int c = 0;
            do
            {
                bvehicle.TakeParkingDuration();
                bvehicle.CalculatePCharge();
                Console.WriteLine("Enter 1 to recalculate hours or else to return to previous: ");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c == 1);
        }
        static void Process(Truck tvehicle)
        {
            int c = 0;
            do
            {
                tvehicle.TakeParkingDuration();
                tvehicle.CalculatePCharge();
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

            Console.WriteLine("Parking Vehicle: Which vehicle do you have\n enter 1: Car 2: Bike 3: Truck, \t -1 to exit");
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
                            Truck tobj = new Truck();
                            Process(tobj);
                            break;
                        case 4:
                            //SUV sobj = new SUV();
                            //Process(sobj);
                            //break;
                        
                        default:
                            break;
                    }
                }
                Console.WriteLine("Parking Vehicle: Which vehicle do you have\n enter 1: Car 2: Bike 3: Truck, \t -1 to exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
