using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        string name;
        Address address;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                this.name = name;
            else
                Console.WriteLine("Något gick fel");
        }
        public Address GetAddress()
        {
            return address;
        }
        public void SetAddress(Address address)
        {
            if (address != null && address is Address)
                this.address = address;
            else
                Console.WriteLine("Något gick fel");
        }

    }
}
