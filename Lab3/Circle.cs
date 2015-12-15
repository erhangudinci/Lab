using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Circle
    {
        double diameter;
        Point center;
        double circumference;



        public double GetDiameter()
        {
            return diameter;
        }
        public void SetDiameter(double diameter)
        {
            if (diameter < 0)
                Console.WriteLine("Något gick fel");
            this.diameter = diameter;
        }
        public double GetCircumference(double number)
        {
            this.circumference = number * 3.1416;
            
            return circumference;
        }
        public Point GetCenter()
        {
            return center;
        }
        public void SetCenter(Point p)
        {
            if (p != null && p is Point)
                this.center = p;
            else
                Console.WriteLine("Något gick fel");
        }
    }
}
