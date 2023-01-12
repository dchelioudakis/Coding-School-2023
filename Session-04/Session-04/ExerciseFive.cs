using System;

namespace Session_04
{

    public class SecondsConversion
    {

        public void Calculate()
        {

            /*5.Write a C# program that takes an integer representing seconds (for example 45678) and converts it to :
                • Minutes
                • Hours
                • Days
                • Years
            */

            int seconds = 78945687;
            int minutes = seconds / 60;
            int hours = seconds / 3600;
            int days = seconds / 86400;
            int years = seconds / 31536000;
            
        }

    }
}