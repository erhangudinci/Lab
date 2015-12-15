using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Point point = new Point();
            Random r = new Random();
            Console.WriteLine("HUr många cirklar vill du skapa?");
            int userInput = int.Parse(Console.ReadLine());
            double[] diameter = new double[userInput];

            double randomDiameter = 0;
            int randomX = 0;
            int randomY = 0;

            CheckDiameter(diameter, randomDiameter);
            Circumference(circle, diameter);

            int[] xCoordinate = new int[userInput];
            int[] yCoordinate = new int[userInput];
            XCoordinates(circle, point, r, xCoordinate, ref randomX);
            YCoordinates(circle, point, r, yCoordinate, ref randomY);
            ChangeDiameter(circle, diameter, xCoordinate, yCoordinate);
            Duplicated(userInput, diameter, xCoordinate, yCoordinate);
            FourCircle(circle, userInput, diameter, xCoordinate, yCoordinate);
            CheackArea(diameter);
            ChangeX(xCoordinate);
            ChangY(xCoordinate, yCoordinate);
        }

        private static void ChangY(int[] xCoordinate, int[] yCoordinate)
        {
            Console.WriteLine("Skriv ett Y koordinat som förflyttar jag alla cirklar i y koordinat \r\nefter vad du har anget?");
            int userY = int.Parse(Console.ReadLine());

            for (int i = 0; i < xCoordinate.Length; i++)
            {
                Console.WriteLine($"Den gamla y koordinat {yCoordinate[i]}");
                yCoordinate[i] = userY;
                Console.WriteLine($"Den nya y koordinat {yCoordinate[i]}");
            }
        }

        private static void ChangeX(int[] xCoordinate)
        {
            Console.WriteLine("Skriv ett X koordinat som förflyttar jag alla cirklar i x koordinat \r\nefter vad du har anget?");
            int userX = int.Parse(Console.ReadLine());

            for (int i = 0; i < xCoordinate.Length; i++)
            {
                Console.WriteLine($"Den gamla x koordinat {xCoordinate[i]}");
                xCoordinate[i] = userX;
                Console.WriteLine($"Den nya x koordinat {xCoordinate[i]}");
            }
        }

        private static void CheackArea(double[] diameter)
        {
            Console.WriteLine("Skriv ett nummer som är en area så skriver jag ut de cirklar\r\nsom har större area än det du har anget?");
            double usersArea = int.Parse(Console.ReadLine());
            for (int i = 0; i < diameter.Length; i++)
            {
                double circleArea = Math.PI * ((diameter[i] / 2) * (diameter[i] / 2));
                if (usersArea < circleArea)
                {
                    Console.WriteLine($"Arean du har anget är {usersArea} och här är de cirklarna/cirkeln som större \r\narea än ditt area {circleArea:f0}");
                }
            }
        }

        private static void FourCircle(Circle circle, int userInput, double[] diameter, int[] xCoordinate, int[] yCoordinate)
        {
            double[] firstCirleD = new double[userInput];
            double[] secondCirleD = new double[userInput];
            double[] thirdCirleD = new double[userInput];
            double[] fourthCirleD = new double[userInput];
            double[] firstCircleX = new double[userInput];
            double[] firstCircleY = new double[userInput];
            double[] secondCircleX = new double[userInput];
            double[] secondCircleY = new double[userInput];
            double[] thirdCircleX = new double[userInput];
            double[] thirdCircleY = new double[userInput];
            double[] fourthCircleX = new double[userInput];
            double[] fourthCircleY = new double[userInput];
            for (int i = 0; i < diameter.Length; i++)
            {
                firstCirleD[i] = diameter[i] / 4;
                secondCirleD[i] = diameter[i]  / 4;
                thirdCirleD[i] = diameter[i]  / 4;
                fourthCirleD[i] = diameter[i]  / 4;
                Console.WriteLine(firstCirleD[i]);
                firstCircleX[i] = xCoordinate[i] - (((diameter[i] * Math.PI) / 4) / Math.PI);
                firstCircleY[i] = yCoordinate[i] - (((diameter[i] * Math.PI) / 4) / Math.PI);
                secondCircleX[i] = xCoordinate[i] - (((diameter[i] * Math.PI) / 4) / Math.PI);
                secondCircleY[i] = yCoordinate[i] + (((diameter[i] * Math.PI) / 4)  / Math.PI);
                thirdCircleX[i] = xCoordinate[i] + (((diameter[i] * Math.PI) / 4) / Math.PI);
                thirdCircleY[i] = yCoordinate[i] - (((diameter[i] * Math.PI) / 4)  / Math.PI);
                fourthCircleX[i] = xCoordinate[i] + (((diameter[i] * Math.PI) / 4)  / Math.PI);
                fourthCircleY[i] = yCoordinate[i] + (((diameter[i] * Math.PI) / 4)  / Math.PI);
                Console.WriteLine($"{(i+1)} cirkelns diameter är {diameter[i]:f2} på xpos {xCoordinate[i]} på ypos {yCoordinate[i]}");
                Console.WriteLine($"{(i + 1)} cirkelns diameter är {firstCirleD[i]:f2} på xpos {firstCircleX[i]} på ypos {firstCircleY[i]}");
                Console.WriteLine($"{(i + 1)} cirkelns diameter är {secondCirleD[i]:f2} på xpos {secondCircleX[i]} på ypos {secondCircleY[i]}");
                Console.WriteLine($"{(i + 1)} cirkelns diameter är {thirdCirleD[i]:f2} på xpos {thirdCircleX[i]} på ypos {thirdCircleY[i]}");
                Console.WriteLine($"{(i + 1)} cirkelns diameter är {fourthCirleD[i]:f2} på xpos {fourthCircleX[i]} på ypos {fourthCircleY[i]}");
            }
        }


        private static void Duplicated(int userInput, double[] diameter, int[] xCoordinate, int[] yCoordinate)
        {
            double[] duplicatedDiameter = new double[userInput];
            duplicatedDiameter = diameter.Clone() as double[];
            int[] duplicatedXCoordinate = new int[userInput];
            duplicatedXCoordinate = xCoordinate.Clone() as int[];
            int[] duplicatedYCoordinate = new int[userInput];
            duplicatedYCoordinate = yCoordinate.Clone() as int[];
            for (int i = 0; i < duplicatedDiameter.Length; i++)
            {
                duplicatedXCoordinate[i] *= -1;
                duplicatedYCoordinate[i] *= -1;
                Console.WriteLine($"kordinaterna från början {xCoordinate[i]}  {yCoordinate[i]}");
                Console.WriteLine($"Motsatta kordinater {duplicatedXCoordinate[i]}  {duplicatedYCoordinate[i]}");
            }
            
        }

        private static void ChangeDiameter(Circle circle, double[] diameter, int[] xCoordinate, int[] yCoordinate)
        {
            string output = "";
            for (int i = 0; i < xCoordinate.Length; i++)
            {
                double origo = Math.Sqrt(xCoordinate[i] * xCoordinate[i] + yCoordinate[i] * yCoordinate[i]);
                if (origo <= 12 && origo >= 0)
                {
                    output += $"Den gamla diameter är {diameter[i]} i diameter \r\n";
                    double howMuchToChangeDiameter = origo - diameter[i] / 2;
                    if (diameter[i] / 2 <= 12)
                    {
                        circle.SetDiameter(diameter[i] + howMuchToChangeDiameter * 2);
                        diameter[i] = circle.GetDiameter();
                        output += $"och den nya diametern är {diameter[i]:f2}";
                    }
                    else if(diameter[i] / 2 > 12)
                    {
                        circle.SetDiameter(diameter[i] + howMuchToChangeDiameter * 2);
                        diameter[i] = circle.GetDiameter();
                        output += $"noch den nya diametern är {diameter[i]:f2}";
                    }
                }
            }
           Console.WriteLine(output);
        }

        private static void YCoordinates(Circle circle, Point point, Random r, int[] yCoordinate, ref int randomY)
        {
            for (int i = 0; i < yCoordinate.Length; i++)
            {
                randomY = r.Next(0, 50);
                point.SetY(randomY);
                circle.SetCenter(point);
                yCoordinate[i] = circle.GetCenter().GetY();
                Console.WriteLine("y" +yCoordinate[i]);
            }
        }
        private static void XCoordinates(Circle circle, Point point, Random r, int[] xCoordinate, ref int randomX)
        {
            for (int i = 0; i < xCoordinate.Length; i++)
            {
                randomX = r.Next(0, 50);
                point.SetX(randomX);
                circle.SetCenter(point);
                xCoordinate[i] = circle.GetCenter().GetX();
                Console.WriteLine("x" + xCoordinate[i]);
            }
        }

        private static void Circumference(Circle circle, double[] numberOfCirclesDiameter)
        {
            int count = 0;
            for (int i = 0; i < numberOfCirclesDiameter.Length; i++)
            {
                if (circle.GetCircumference(numberOfCirclesDiameter[i]) >= 2 && circle.GetCircumference(numberOfCirclesDiameter[i]) <= 22)
                {
                    count++;
                }
            }
            Console.WriteLine("Det är så många som har omkretsen mellan 2 - 22: {0}",count);
            
        }

        private static void CheckDiameter(double[] numberOfCirclesDiameter, double randomDiameter)
        {
            CreateCircle(numberOfCirclesDiameter, randomDiameter);

            string outPut = "De finns på plats : ";
            for (int i = 0; i < numberOfCirclesDiameter.Length; i++)
            {
                if (numberOfCirclesDiameter[i] >= 2 && numberOfCirclesDiameter[i] <= 17)
                {
                    outPut += i + " , ";
                }
            }
            Console.WriteLine(outPut);
        }
        
        public static double[] CreateCircle(double[] circles, double randomDiameter)
        {
            Circle circle = new Circle();
            
            Random r = new Random();
            for (int i = 0; i < circles.Length; i++)
            {
                randomDiameter = Convert.ToDouble(r.Next(0, 50));
                circle.SetDiameter(randomDiameter);
                circles[i] = circle.GetDiameter();
            }
            return circles;
            
        }
    }
}
//Person person = new Person();
//person.SetName("a");
//Console.WriteLine(person.GetName());
//Circle circle = new Circle();
//circle.SetDiameter(3.4);
//Console.WriteLine(circle.GetCircumference());
//Point point = new Point();
//point.SetX(3);
//point.SetY(4);
//circle.SetCenter(point);
//Console.WriteLine(circle.GetCenter().GetX());
//Address address = new Address();
//address.SetStreet("hej");
//address.SetStreetNumber(11);
//person.SetAddress(address);
//Console.WriteLine(person.GetAddress().GetStreet() + person.GetAddress().GetStreetNumber());
