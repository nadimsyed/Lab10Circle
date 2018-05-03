using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            bool truth = true;
            while (truth)
            {
                Console.Write("Enter radius: ");
                string radius = Console.ReadLine();

                Validator validator = new Validator(radius);
                //double conv = validator.Checker(radius);


                if (!Regex.IsMatch(radius, @"\s") && !Regex.IsMatch(radius, @"[a-zA-Z]") && validator.Checker(radius))
                {
                    double rad = double.Parse(radius);

                    if (rad > 0 )
                    {
                        //Console.WriteLine("What do you want to call this circle");
                        //string name = Console.ReadLine();
                        Circle circleOne = new Circle(rad);

                        Console.WriteLine(circleOne.CalculareFormattedCircumference());
                        Console.WriteLine(circleOne.CalculareFormattedArea());

                        truth = Continue();
                        if (!truth)
                        {
                            Console.WriteLine($"Goodbye. You created {circleOne.CountChecker()} Circle object(s).");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    } 
                }
                else
                {
                    Console.WriteLine("\nInvalid input, Please enter an integer.");
                }
                
            }
        }

        public static bool Continue()
        {
            while (true)
            {
                Console.Write("\t\t\t\t\t\tContinue? (y/n): ");

                string jump = Console.ReadLine().ToUpper();

                if (jump == "N")
                {
                    return false;
                }
                else if (jump == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Input was not \"y\" or \"n\"! Please try again!");
                    continue;
                }
            }
        }

    }
}
