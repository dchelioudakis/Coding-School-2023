using System;



namespace Session_04
{

    public class SupriseMessage
    {

        public string Get()
        {

            //4.Write a C# program that assigns an age (number) (for example 20) and a gender (string) (for example female) and displays something like: "You are female and look younger than 20."
            int age = 27;
            string gender = "female";


            string diplayMessage = "OMG! Unbelievable! You are " + gender + " and you look younger than " + age;


            return diplayMessage;

        }

    }
}
