namespace Vehicles
{
    class Vehicle
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");
        }

        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of the Drive method");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car:Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }

        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Airplane : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }

        public override void Drive()
        {
            Console.WriteLine("Flying");
        }
    }
}

using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.StopEngine("Whirr");

            Console.WriteLine("\nJourney by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
