using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarSearch.Model
{
    public class Guitar
    {
        public string SerialNumber { get; }
        public double Price { get; }
        public GuitarSpec Spec { get; }

        public Guitar(string serialNumber, double price, GuitarSpec specs)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = specs;
        }
    }
}
