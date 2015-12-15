using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift3();
            MyDoubleType mdt1 = new MyDoubleType(5);

            MyDoubleType mdt2 = mdt1 + 5;

            MyDoubleType mdt3 = mdt1 + mdt2;

            MyDoubleType mdt4 = new MyDoubleType(5);

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",

                 mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);
        }

        private static void Uppgift3()
        {
            Point point = new Point(3, 4);
            Console.WriteLine(point);
            Point3D point3D = new Point(3, 2);
            Console.WriteLine(point3D);
        }

        private static void Uppgift1()
        {
            float firstFloat = 0.3f;
            long firstLong = -123234L;
            char firstChar = 'a';
            string firstSTring = "hej";
            ulong firstULong = 38532469576957325L;
        }
    }
}
