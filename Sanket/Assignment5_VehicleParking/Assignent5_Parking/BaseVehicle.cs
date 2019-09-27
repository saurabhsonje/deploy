using System;

namespace Assignent5_Parking
{
    public class BaseVehicle : VehicleParking
    {
        protected int hourlycharge;
        protected int hourstatus;
        protected int maxspeed;
        protected int totalcharge;

        public int GShourstatus { get { return hourstatus; } set { hourstatus = value; } }
        public int GStotalcharge { get { return totalcharge; } set { totalcharge = value; } }
        public BaseVehicle()
        {
            hourlycharge = 10;
            hourstatus = 0;
            maxspeed = 10;
        }
        public void CalculatePCharge()
        {
            totalcharge = (hourlycharge * hourstatus);
            Console.WriteLine("Parking charge of " + this.GetType() + " is : " + totalcharge);
        }

        public virtual void Run()
        {
            Console.WriteLine(this.GetType() + " can run with speed of " + maxspeed + " km/hr");
        }
    }
    public class Car : BaseVehicle
    {
        //base() = 8;
        //base().hourstatus = 9;
        public Car() : base()
        {
            hourlycharge = 10;
            //hourstatus = 0;
            maxspeed = 100;
        }
        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }
    }

    public class Bike : BaseVehicle
    {
        public Bike() : base()
        {
            hourlycharge = 5;
            //hourstatus = 0;
            maxspeed = 70;
        }
        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }
    }
    public class SUV : BaseVehicle
    {
        public SUV() : base()
        {
            hourlycharge = 20;
            //hourstatus = 0;
            maxspeed = 140;
        }
        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }
    }
    public class Truck : BaseVehicle
    {
        public Truck() : base()
        {
            hourlycharge = 50;
            //hourstatus = 0;
            maxspeed = 90;
        }
        public override void Run()
        {
            Console.WriteLine("Can run with speed of" + maxspeed + " km/hr");
        }

    }

}