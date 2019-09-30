using System;

namespace Assignent5_Parking
{
    public class BaseVehicle
    {
        protected int hourlycharge;
        protected int hourlyduration;
        protected int maxspeed;
        protected int totalcharge;

        public int GShourstatus { get { return hourlyduration; } set { hourlyduration = value; } }
        public int GStotalcharge { get { return totalcharge; } set { totalcharge = value; } }
        public BaseVehicle()
        {
            hourlycharge = 10;
            hourlyduration = 0;
            maxspeed = 10;
        }

        public virtual void Run()
        {
            Console.WriteLine(this.GetType() + " can run with speed of " + maxspeed + " km/hr");
        }
    }
    public class Car : BaseVehicle, Vehicle
    {
        //base() = 8;
        //base().hourstatus = 9;
        public Car() : base()
        {
            hourlycharge = 10;
            maxspeed = 100;
        }

        public void CalculatePCharge()
        {
            this.totalcharge = (hourlycharge * hourlyduration);
            Console.WriteLine("Parking charge of " + this.GetType() + " is : " + totalcharge);
        }

        public void TakeParkingDuration()
        {
            Console.WriteLine("Enter hour duration of parking: ");
            this.hourlyduration = Convert.ToInt32(Console.ReadLine());
        }

        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }
    }

    public class Bike : BaseVehicle, Vehicle
    {
        public Bike() : base()
        {
            hourlycharge = 5;
            maxspeed = 70;
        }
        public void CalculatePCharge()
        {
            this.totalcharge = (hourlycharge * hourlyduration);
            Console.WriteLine("Parking charge of " + this.GetType() + " is : " + totalcharge);
        }

        public void TakeParkingDuration()
        {
            Console.WriteLine("Enter hour duration of parking: ");
            this.hourlyduration = Convert.ToInt32(Console.ReadLine());
        }
        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }
    }
   
    public class Truck : BaseVehicle, Vehicle  
    {
        public Truck() : base()
        {
            hourlycharge = 50;
            maxspeed = 90;
        }
        public void CalculatePCharge()
        {
            this.totalcharge = (hourlycharge * hourlyduration);
            Console.WriteLine("Parking charge of " + this.GetType() + " is : " + totalcharge);
        }

        public void TakeParkingDuration()
        {
            Console.WriteLine("Enter hour duration of parking: ");
            this.hourlyduration = Convert.ToInt32(Console.ReadLine());
        }
        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }

    }

}