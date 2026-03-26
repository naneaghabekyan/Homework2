using System;


namespace homework_inheritance
{
    public class Vehicle
    {
        public double Speed { get; private set; }
        public Vehicle(double speed)
        {
            if (speed < 0)
            {
                Console.WriteLine("Speed can't be negative. Speed is set to 100");
                Speed = 100;
            }
            else
                Speed = speed;
        }

        public void Start()
        {
            Console.WriteLine("Vehicle started working!");
            Console.WriteLine("Speed: " + Speed);
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; private set; }
        public Car(double speed, int numofdoors = 4) : base(speed)
        {
            NumberOfDoors = numofdoors;
        }
        public void ShowCar()
        {
            Console.WriteLine("Number of doors: " + NumberOfDoors);
        }
    }

    public class Bike : Vehicle
    {
        public bool HasPedals { get; private set; }
        public Bike(double speed, bool pedals = true) : base(speed)
        {
            HasPedals = pedals;
        }
        public void ShowBike()
        {
            Console.WriteLine(HasPedals ? "Has pedals" : "Doesn't have pedals");
        }
    }

    public class Truck : Vehicle
    {
        public double LoadCapacity { get; private set; }
        public Truck(double speed, double lcapacity) : base(speed)
        {
            LoadCapacity = lcapacity;
        }
        public void ShowTruck()
        {
            Console.WriteLine("Load capacity: " + LoadCapacity);
        }
    }
}
