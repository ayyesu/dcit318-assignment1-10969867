using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter the length for the 3 (three) sides...");

                Console.WriteLine("Side1:");

                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Side2:");

                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Side3");

                double side3 = Convert.ToDouble(Console.ReadLine());


                Triangle triangle = new Triangle(side1, side2, side3);

                if (triangle.IsValidTriangle())
                {
                    string triangleType = triangle.DetermineTriangleType();

                    if (triangleType == "Equilateral")
                    {
                        Console.WriteLine($"Triangle is an {triangleType} triangle because all sides are equal");
                    }else if (triangleType == "Isosceles")
                    {
                        Console.WriteLine($"Triangle is a {triangleType} triangle because only two sides are equal");
                    }
                    else
                    {
                        Console.WriteLine($"Triangle is a {triangleType} triangle because none of the sides are equal");
                    }
                    

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The sides doesn't form a valid triangle");

                    Console.ReadLine();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid inputs, The input for the sides doesn't fit to be a triangle");
            }
        }
    }
}
