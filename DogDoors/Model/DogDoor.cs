using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DogDoors.Model
{
    public class DogDoor
    {
        private bool open;
        private Timer timer;

        public DogDoor()
        {
            open = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;

            SetTimer();
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

        private void SetTimer()
        {
            timer = new Timer(OnTimedEvent, null, 0, 5000);
        }

        private void OnTimedEvent(object o)
        {
            Close();
            timer.Dispose();
        }
    }
}
