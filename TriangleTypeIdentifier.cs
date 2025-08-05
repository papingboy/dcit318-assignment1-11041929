using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter side 1: ");
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