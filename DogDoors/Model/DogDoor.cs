using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoors.Model
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }
    }
}
