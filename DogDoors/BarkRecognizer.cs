using DogDoors.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoors
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(string bark)
        {
            Console.WriteLine("     BarkRecognizer: Heard a " + bark);
            door.Open();
        }
    }
}
