using System;

namespace GradeCalculator
{
    class Grade
    {
        public double Score { get; private set; }

        public Grade(double score)
        {
            Score = score;
        }

        public string GetLetterGrade()
        {
            if (Score >= 90)
                return "A";
            else if (Score >= 80)
                return "B";
            else if (Score >= 70)
                return "C";
            else if (Score >= 60)
                return "D";
            else
                return "F";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double score;
            while (true)
            {
                Console.Write("Enter a numerical grade between 0 and 100: ");
                if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                }
            }

            Grade grade = new Grade(score);
            string letterGrade = grade.GetLetterGrade();
            Console.WriteLine($"The letter grade for {score} is {letterGrade}.");
        }
    }
}
