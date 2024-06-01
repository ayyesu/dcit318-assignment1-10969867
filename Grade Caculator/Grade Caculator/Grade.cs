using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Caculator
{
    public class Grade
    {
        public int NumGrade { get; set; }

        // Constructor
        public Grade(int grade)
        {
            NumGrade = grade;
        }

        // Method to determine Grade Letter
        public string GetGradeLetter()
        {
            if (NumGrade >= 90)
            {
               return "A";
            }else if (NumGrade >= 80)
            {
                return "B";
            }else if (NumGrade >= 70)
            {
                return "C";
            }else if (NumGrade >= 60)
            {
                return "D";
            }else
            {
                return "F";
            }
        }
    }
}
