using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DogDoors.Model
{
    public class Remote
    {
        private DogDoor door;
        private Timer timer;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");

            if(door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
            }

            SetTimer();
        }

        private void SetTimer()
        {
            timer = new Timer(OnTimedEvent, null, 0, 5000);
        }

        private void OnTimedEvent(object o)
        {
            door.Close();
            timer.Dispose();
        }
    }
}
