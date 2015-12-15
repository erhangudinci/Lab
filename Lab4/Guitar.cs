using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Guitar
    {
        private int guitarString;
        private string guitarColor;
        private string guitarType;
        private int guitarCost;
        public static int count;
        public int GuitarString
        {
            get { return guitarString; }
            set
            {
                var validGuitarString = value != null || value == 6 || value == 12;
                if (validGuitarString)
                    guitarString = value;
                else
                {
                    Console.WriteLine("Något blev fel. Det finns 6 och 12 strängars gitarrer");
                }
            }
        }
        public string GuitarColor
        {
            get { return guitarColor; }
            set
            {
                var validGuitarColor = !string.IsNullOrWhiteSpace(value);
                if (validGuitarColor)
                    guitarColor = value;
                else
                    Console.WriteLine("Något blev fel");
            }
        }
        public string GuitarType
        {
            get { return guitarType; }
            set
            {
                var valdGuitarType = !string.IsNullOrWhiteSpace(value);
                if (valdGuitarType)
                    guitarType = value;
                else
                {
                    Console.WriteLine("Något blev fel! Prova igen");
                }
            }
        }
        public int GuitarCost
        {
            get { return guitarCost; }
            set
            {
                var validGuitarCost = value != null && value >= 0 && value <= 200000;
                if (validGuitarCost)
                    guitarCost = value;
                else
                {
                    Console.WriteLine("Något blev fel! Prova igen");
                }
            }
        }
        public Guitar(int guitarString = 6, string guitarColor = "natur", string guitarType = "klassisk gitarr", int guitarCost = 1000)
        {
            GuitarString = guitarString;
            GuitarColor = guitarColor;
            GuitarType = guitarType;
            GuitarCost = guitarCost;
            count++;
        }
        public Guitar(int guitarString, string guitarType, int guitarCost, string guitarColor)
        {
            GuitarString = guitarString;
            GuitarColor = guitarColor;
            GuitarType = guitarType;
            GuitarCost = guitarCost;
        }
        public Guitar(int count)
        {
            count = 0;
        }
        public string playGuitar(string userInput)
        {
            string played = "";
            switch (userInput)
            {
                case "e":
                    {
                        played += "Du spelade ljusa E";
                        break;
                    }
                case "b":
                    {
                        played += "Du spelade B";
                        break;
                    }
                case "g":
                    {
                        played += "Du spelade G";
                        break;
                    }
                case "d":
                    {
                        played += "Du spelade D";
                        break;
                    }
                case "a":
                    {
                        played += "Du spelade ljusa a";
                        break;
                    }
                case "E":
                    {
                        played += "Du spelade mörka E";
                        break;
                    }
            }
            return played;
        }
        public override string ToString() => $"Typ: {guitarType} Kostnad: {guitarCost} Färg: {guitarColor} Strängar: {guitarString}";
    }
}
