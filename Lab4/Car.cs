using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Car
    {
        
        private string carType;

        public int Label { get; set; }
        public int NumberOfGears { get; set; }
        public int Color { get; set; }
        public string Cartype
        {
            get { return carType; }
            set
            {
                var validCarType = value.ToLower().Trim() == "kupe" || value.ToLower() == "kombi";
                if (validCarType)
                {
                    carType = value.ToLower();
                }
                else
                    Console.WriteLine("Något gick fel.");
            }
        }

    }
}
