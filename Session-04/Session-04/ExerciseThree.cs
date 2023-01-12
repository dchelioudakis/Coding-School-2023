using System;


namespace Session_04
{

    public class MixedCalculations
    {

        public string Get()
        {

            //3. Write a C# program to print the result of the specified operations
            int calcOne = -1 + (5 * 6);
            int calcTwo = 38 + (5 % 7);
            double calcThree = 14.0 + (-3.0 * 6.0) / 7.0;
            double calcFour = 2 + ((13 / 6) * 6) + Math.Sqrt(7);
            double calcFive = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);

            string diplayMessage = "-1 + (5 * 6) = " + calcOne +
                "\n" + "38 + (5%7) = " + calcTwo +
                "\n" + "14 + (-3x6)/7 = " + calcThree +
                "\n" + "2 + (13/6)x6 + sqrt(7) = " + calcFour +
                "\n" + "(pow(6,4) + pow(5,7)) / (9%4) = " + calcFive;

            return diplayMessage;

        }

    }
}