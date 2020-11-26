using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarSearch.Model
{
    public class Inventory
    {
        public List<Guitar> Guitars { get; }

        public Inventory()
        {
            Guitars = new List<Guitar>();
        }

        public void AddGuitar(String serialNumber, double price, GuitarSpec guitarSpecs)
        {
            Guitar guitar = new Guitar(serialNumber, price, guitarSpecs);

            Guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in Guitars)
            {
                if (!string.IsNullOrEmpty(guitar.SerialNumber) && guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach(Guitar guitar in Guitars)
            {
                if(guitar.Spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }
    }
}
