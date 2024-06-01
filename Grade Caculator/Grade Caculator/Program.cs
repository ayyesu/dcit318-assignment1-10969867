using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Caculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Numerical Grade between 0 - 100: ");

            // Get input from user
            string input = Console.ReadLine();

            int numGrade;

            // Validating the input
            if (int.TryParse(input, out numGrade) && numGrade >= 0 && numGrade <= 100)
            {
                // Creating a grade
                Grade grade = new Grade(numGrade);

                // Getting and dispaying grade letter
                string gradeLetter = grade.GetGradeLetter();

                Console.WriteLine($"Your Calculated Grade is: {gradeLetter}");

                // Prevents Console from closing
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input, Please enter a numerical grade between 0 and 100.");

                Console.ReadLine();
            }

        }
    }
}
