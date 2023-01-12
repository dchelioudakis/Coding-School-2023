using System;

namespace Session_04
{
    // 2. Write a C# program to print the sum of two numbers and the division of those two numbers.
    public class SumAndDivision
    {
        int numberA = 45;
        int numberB = 3;

        public string GetSum()
        {

            int sumAB = numberA + numberB;
            string displayMessage = "Sum of " + numberA + " and " + numberB + " is: " + sumAB;
            ;

            return displayMessage;

        }
        public string GetDivision()
        {
            int divisionAB = numberA / numberB;
            string displayMessage = "Division of " + numberA + " and " + numberB + " is: " + divisionAB;

            return displayMessage;

        }

    }
}