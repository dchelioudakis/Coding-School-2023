using System;

namespace Session_04
{

    public class SecondsConversionRevision
    {

        public void Calculate()
        {

            //6. Rewrite Program #5 using .Net Libraries.

            int seconds = 78945687;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            double minutes = time.TotalMinutes;
            double hours = time.TotalHours;
            double days = time.TotalDays;
            double years = days / 365;

        }

    }
}
