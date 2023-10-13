using System;

namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[2];

            Car myCar = new Car
            {
                FactoryName = "Toyota",
                Model = "Camry",
                Color = "Red",
                DriveTime = 2,
                DrivePath = 100,
                DoorCount = 4,
                IsElectricCar = false,
            };

            Bicycle myBicycle = new Bicycle
            {
                FactoryName = "Schwinn",
                Model = "Mountain Bike",
                Color = "Blue",
                DriveTime = 1,
                DrivePath = 10,
                Type = "Mountain Bike",
            };

            vehicles[0] = myCar;
            vehicles[1] = myBicycle;

            foreach (var vehicle in vehicles)
            {
            	vehicle.DefineNatureHarmness();
                vehicle.AverageSpeed();
                vehicle.GetInfo(); 
                Console.WriteLine();
            }

            // TODO: Implement other functionality here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }

    abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }
        private readonly DateTime ProductionDate;

        public abstract void AverageSpeed();
        public abstract void DefineNatureHarmness();
        public override string ToString()
        {
            return FactoryName + " " + Model;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Factory Name: " + FactoryName);
            Console.WriteLine("Model: " + Model);
        }
    }


    class Car : Vehicle
    {
        public int DoorCount;
        public bool IsElectricCar;

         public override void DefineNatureHarmness()
        {
        	if (IsElectricCar)
            {
                Console.WriteLine("Low");
            }
            else
            {
                Console.WriteLine("High");
            }
        }
        
        public override void AverageSpeed()
        {
            int averageSpeed = DrivePath / DriveTime;
            Console.WriteLine("Average Speed for Car: " + averageSpeed + " mph");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Door Count: " + DoorCount);
            Console.WriteLine("Is Electric Car: " + IsElectricCar);
        }
    }

    class Bicycle : Vehicle
    {
        public string Type;

        public override void AverageSpeed()
        {
            int averageSpeed = DrivePath / DriveTime;
            Console.WriteLine("Average Speed for Bicycle: " + averageSpeed + " mph");
        }
        public override void DefineNatureHarmness()
        {
        	Console.WriteLine("None");        
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Type: " + Type);
        }
    }
}
