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
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            try
            {
                Thread.Sleep(10000);
            }
            catch (Exception e) { }

            Console.WriteLine("...but he's stuck outside!");

            Console.WriteLine("\nFido starts barking...");
            Console.WriteLine("...so Gina grabs the remote control.");
            remote.PressButton();

            Console.WriteLine("\nFido's back inside...");

        }
    }
}
