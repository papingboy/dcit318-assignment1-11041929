using System;

namespace DCIT318Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nDCIT 318: Assignment 1");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        // Grade Calculator
        static void GradeCalculator()
        {
            Console.Write("\nEnter numerical grade (0 - 100): ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }

        // Ticket Price Calculator
        static void TicketPriceCalculator()
        {
            Console.Write("\nEnter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");
        }

        // Triangle Type Identifier
        static void TriangleTypeIdentifier()
        {
            Console.Write("\nEnter side 1: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}