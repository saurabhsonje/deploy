using System;

namespace Assignment5
{
    interface Vehicle
    {
        int Bus();
        int Car();
        double Bike();
    }

    class CalculateParkingCharges: Vehicle
    {
        static void Main(string[] args)
        {
            CalculateParkingCharges charges = new CalculateParkingCharges();
            Console.WriteLine("Bike parking charges - Rs."+charges.Bike()+ "\nCar parking charges - Rs." + charges.Car()+ "\nBus parking charges - Rs." + charges.Bus());
        }

        public int calculateCharges(int time)
        {
            int charge=0;
            charge = time * 20;

            return charge;
        }

        public double calculateCharges(double time)
        {
            double charge = 0;
            charge = time * 20.0;

            return charge;
        }

        public double Bike()
        {
            return calculateCharges(1.5);
        }

        public int Bus()
        {
            return calculateCharges(4);
        }

        public int Car()
        {
            return calculateCharges(3);
        }
    }
}
