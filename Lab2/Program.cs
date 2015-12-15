using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dowJones = 4.6;
            double nasdaq = 4.1;
            double stockholm = -2.1;
            double milano = -6.7;
            double paris = -5.5;
            
            Console.WriteLine($"Dow Jones sjönk med {dowJones} procent och Nasdaq med {nasdaq} procent. Stockholm {stockholm} procent, Milano {milano}procent, Paris {paris} procent.");

            const double pi = 3.141592654;
            Console.WriteLine($"Talet πi är cirka {pi} men kan avrundas till {pi:n2} och kan lite grovt skrivas som {pi:G2}");

            string jonas = "Han heter Jonas och bor i Helsingborg på Stattena vid Hemköp.";
            Console.WriteLine(jonas);
        }
    }
}
