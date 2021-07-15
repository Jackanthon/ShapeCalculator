using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ASsignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Welcome to my simple shape calculator!\n");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Run(name);


            Console.ReadLine();
        }
        static void Run(string name)
        {
            Console.WriteLine("Please choose which you'd like to get:\n");
            Console.Write("Enter 1 for Circle or 2 for Square or 3 for Triangle or Click Anything to Quit\n");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Circle circle = new Circle();
                Console.WriteLine("What's the radius?");
                circle.radius = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"{name}, perimeter is {circle.Perimeter()} and the area is \n" + circle.Area());
                Run(name);
            }
            if (userChoice == "2")
            {
                Square square = new Square();
                Console.WriteLine("Give me the length of one side");
                square.Side = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"{name}, perimeter of the square is {square.Perimeter()} and the area is \n" + square.Area());
                Run(name);
            }
            if (userChoice == "3")
            {
                Triangle triangle = new Triangle();
                Console.WriteLine("Give me 3 sides and I'll do the rest");
                Console.Write("Side 1: ");
                triangle.Side1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Side 2: ");
                triangle.Side2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Side 3: ");
                triangle.Side3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{name}, perimeter to the triangle is {triangle.Perimeter()} and the area is {triangle.Area()}\n");
                Run(name);
            }
            else { Environment.Exit(0); }
        }
    }
}
//Write a class : Shape and add basic properties like id, name and description and method like calculate area .
//Inherit circle shape from base class and add properties like radius. Add calculate area logic.
//Inherit square class from shape and add change the calculate area logic. Add property like side of square.