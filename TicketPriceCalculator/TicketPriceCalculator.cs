using System;

namespace MovieTheater
{
    class Ticket
    {
        public int Age { get; private set; }
        public double Price { get; private set; }

        public Ticket(int age)
        {
            Age = age;
            Price = CalculatePrice();
        }

        private double CalculatePrice()
        {
            if (Age <= 12 || Age >= 65)
            {
                return 7.0;
            }
            else
            {
                return 10.0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid age.");
                }
            }

            Ticket ticket = new Ticket(age);
            Console.WriteLine($"The ticket price for age {age} is GHC{ticket.Price}.");
        }
    }
}
