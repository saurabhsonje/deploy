using System;

namespace Assignment5
{
    interface Vehicle
    {
        void getInput();
        void calParkingCharges();
        
    }

    class Car : Vehicle
    {
        public int durations;
        public  int hourlyparking_charges=50;
        public void getInput()
        {
            Console.WriteLine("Enter the duration of car parking");
            durations = Convert.ToInt32(Console.ReadLine());
          
        }

        public void calParkingCharges()
        {
            int cParkingCharges = durations * hourlyparking_charges;
            Console.WriteLine("Car Parking Charges are:{0}", cParkingCharges);

        }

      
    }

    class Bike : Vehicle
    {
        public int durations;
        public int hourlyparking_charges=30;
        public void getInput()
        {
            Console.WriteLine("Enter the duration of bike parking");
            durations = Convert.ToInt32(Console.ReadLine());
         
        }

        public void calParkingCharges()
        {
            int bParkingCharges = durations * hourlyparking_charges;
            Console.WriteLine("Bike Parking Charges are:{0}", bParkingCharges);

        }


    }

    class Truck : Vehicle
    {
        public int durations;
        public int hourlyparking_charges=100;
        public void getInput()
        {
            Console.WriteLine("Enter the duration of truck parking");
            durations = Convert.ToInt32(Console.ReadLine());
          
        }

        public void calParkingCharges()
        {
            int tParkingCharges = durations * hourlyparking_charges;
            Console.WriteLine("Truck Parking Charges are:{0}", tParkingCharges);

        }


    }
    class Program 
    {
     
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("***********Parking Charges************");
                Console.WriteLine("\n1.Car\n2.Bike\n3.Truck");
                Console.WriteLine("Enter the choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Car c = new Car();
                        c.getInput();
                        c.calParkingCharges();
                        break;
                    case 2:
                        Bike b = new Bike();
                        b.getInput();
                        b.calParkingCharges();
                        break;
                    case 3:
                        Truck t = new Truck();
                        t.getInput();
                        t.calParkingCharges();
                        break;
                    default:
                        Console.WriteLine("Your choice is wrong........");
                        break;


                }
            } while (choice != 0);
           
        }

    }
}
