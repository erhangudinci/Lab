using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Cykel
    {
        private string label;
        private int numberOfGears;
        private string bikeType;
        public static int count;
        public string Label
        {
            get { return label; }
            set
            {
                var validLabel = !string.IsNullOrWhiteSpace(value);
                if (validLabel)
                    label = value;
                else
                    Console.WriteLine("Något blev fel");
            }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                var validNumberOfGears =  value >= 1 && value <= 30;
                if (validNumberOfGears)
                    numberOfGears = value;
                else
                {
                    Console.WriteLine("Något blev fel");
                }
            }
        }
        public string BikeType
        {
            get { return bikeType; }
            set
            {
                var validBikeType = !string.IsNullOrWhiteSpace(value);
                if (validBikeType)
                    bikeType = value;
                else
                    Console.WriteLine("Något blev fel");
            }
        }
        public Cykel()
        {
            Label = "Monark";
            NumberOfGears = 3;
            BikeType = "Damcykel";
            
        }
        public Cykel(string bikeType) : this()
        {
            BikeType = bikeType;
            count++;
        }
        public Cykel(string label, int numberOfGears, string bikeType) : this(bikeType)
        {
            Label = label;
            NumberOfGears = numberOfGears;
            BikeType = bikeType;
        }
        public Cykel(int count)
        {
            count = 0;
        }
        public int changeGears(int userInput)
        {
            return NumberOfGears = userInput;
        }
        public void Bling(int userInput)
        {
            for (int i = 0; i < userInput; i++)
            {
                Console.Beep(3000, 300);
            }
        }
        public override string ToString() => $"Märke: {Label} Antal växlar: {NumberOfGears} Cykel typ: {BikeType}";

    }
}
