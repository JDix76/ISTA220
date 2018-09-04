using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFarm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi, welcome to my farm. Please select 'ENTER' to meet animals at my farm");
            Console.ReadLine();

            Dog d1 = new Dog();
            Console.WriteLine("Hello there, I am a Dog");
            d1.name();
            d1.sound();
            d1.eat();
            d1.like();
            Console.WriteLine("Would you like to meet my friend the Horse? Press 'ENTER'");
            Console.ReadLine();

            horse h1 = new horse();
            Console.WriteLine("Hi, I am a Horse");
            h1.name();
            h1.eat();
            h1.sound();
            h1.like();
            Console.WriteLine("I have a friend that is a sheep, would you like to meet him? Press 'ENTER'");
            Console.ReadLine();

            sheep s1 = new sheep();
            Console.WriteLine("I hope you are not having a Baaaaaad day?");
            s1.name();
            s1.eat();
            s1.sound();
            s1.like();
            Console.WriteLine("I have a friend that rolls around in mud all day, can you guess who it is?" +
                "Would you like to meet him? Press 'ENTER'");
            Console.ReadLine();

            pig p1 = new pig();
            Console.WriteLine("Oink, I am a Pig Oink");
            p1.name();
            p1.eat();
            p1.sound();
            p1.like();
            Console.WriteLine("Seems like you have seen all the animals at this farm." +
                "When your ready to leave the farm, just press 'ENTER'");
            Console.ReadLine();

            Console.WriteLine("Thank you for visiting, hope you come again.");
            Console.ReadLine();







        }
    }
}
