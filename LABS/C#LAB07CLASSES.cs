--Author: James Dix
--Date: 29 August 2018
--Subject: C#LAB07



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            Point ajay = new Point(77, 12);
            double distance = origin.DistanceTo(bottomRight);
            double distance2 = ajay.DistanceTo(origin);

            int oc = Point.ObjectCount();
            Console.WriteLine($"The object count is {oc}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
