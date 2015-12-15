using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radio;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Car car2 = new Car();
            //car.Cartype = "kombi";
            //car2.Cartype = "suv";
            //Console.WriteLine(car.Cartype);
            //Console.WriteLine(car2.Cartype);
            RadioClass();
            //GuitarClass();
            //CykelClass();

        }

        private static void RadioClass()
        {
            RadioClass radio = new RadioClass(frequencySetting: 33, onOff: "on", volym: 4);
            RadioClass radio1 = new RadioClass(frequencySetting: 33, onOff: "on", volym: 7);
            RadioClass radio2 = new RadioClass { FrequencySetting = 33, OnOff = "on" };
            RadioClass radio3 = new RadioClass(volym: 6, onOff: "on", frequencySetting: 35);
            Console.WriteLine(radio3);
            Console.WriteLine(Radio.RadioClass.instanceCount);
        }

        private static void CykelClass()
        {
            Cykel cykel = new Cykel();
            Cykel cykel1 = new Cykel(label: "Cresent", numberOfGears: 4, bikeType: "Herrcykel");
            Cykel cykel2 = new Cykel(bikeType: "herrcykel");
            Cykel cykel3 = new Cykel();
            Console.WriteLine(cykel);
            Console.WriteLine(cykel1);
            Console.WriteLine(Cykel.count);
            Console.WriteLine("Till vilken växel vill du byta");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(cykel.changeGears(userInput));
            Console.WriteLine(cykel);
            Console.WriteLine("Hur många gånger vill du blinga");
            userInput = int.Parse(Console.ReadLine());
            cykel.Bling(userInput);
        }

        private static void GuitarClass()
        {
            Guitar guitar = new Guitar();
            Guitar guitar1 = new Guitar(guitarCost: 5000, guitarColor: "black", guitarType: "stålsträngad");
            Console.WriteLine(guitar1);
            Console.WriteLine($"Antal instanser: {Guitar.count}");
            Console.WriteLine("Vill du spela gitarr? J / N");
            string userInput = Console.ReadLine();
            if (userInput == "j" || userInput == "J")
            {
                Console.WriteLine("Vilken sträng vill du spela? e / b / g / d / a / E");
                userInput = Console.ReadLine();
                Console.WriteLine(guitar.playGuitar(userInput));
            }
            else if (userInput == "n" || userInput == "N")
            {
                Console.WriteLine("hejdå");
            }
            else
                Console.WriteLine("något blev fel");
        }
    }
}
