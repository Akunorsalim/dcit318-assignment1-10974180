using System;

namespace TriangleType
{
    class Triangle
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public string DetermineType()
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                return "Equilateral";
            }
            else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, side3;

            while (true)
            {
                try
                {
                    Console.Write("Enter the length of the first side: ");
                    side1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the length of the second side: ");
                    side2 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the length of the third side: ");
                    side3 = double.Parse(Console.ReadLine());

                    if (side1 > 0 && side2 > 0 && side3 > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lengths must be positive numbers. Please enter again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numerical values.");
                }
            }

            Triangle triangle = new Triangle(side1, side2, side3);
            string type = triangle.DetermineType();
            Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is {type}.");
        }
    }
}
