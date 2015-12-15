using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Address
    {
        string street;
        int streetNumber;
        
        public string GetStreet()
        {
            return street;
        }
        public void SetStreet(string street)
        {
            if (!string.IsNullOrWhiteSpace(street))
                this.street = street;
            else
                Console.WriteLine("Något gick fel");
        }
        public int GetStreetNumber()
        {
            return streetNumber;
        }
        public void SetStreetNumber(int streetNumber)
        {
            if (streetNumber <= 0)
                Console.WriteLine("Något gick fel");
            else
                this.streetNumber = streetNumber;
        }
    }
}
