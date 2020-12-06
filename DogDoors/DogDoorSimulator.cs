using DogDoors.Model;
using System;
using System.Threading;

namespace DogDoors
{
    public class DogDoorSimulator
    {
        public static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            Console.WriteLine("Fido starts barking...");
            recognizer.Recognize("Woof");

            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception e) { }

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("\nFido starts barking...");
            recognizer.Recognize("Woof");

            Console.WriteLine("\nFido's back inside...");

        }
    }
}
