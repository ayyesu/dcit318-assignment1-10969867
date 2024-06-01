using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    class Triangle
    {
        public double Side1 {  get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }


        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public string DetermineTriangleType()
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                return "Equilateral";
            }else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }

        public bool IsValidTriangle()
        {
            return (Side1 > 0 && Side2 > 0 && Side3 > 0) &&
                   (Side1 + Side2 > Side3) &&
                   (Side1 + Side3 > Side2) &&
                   (Side2 + Side3 > Side1);
        }
    }
}
