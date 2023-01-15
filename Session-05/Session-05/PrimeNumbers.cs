using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    //3. Write a C# program that asks the user for an integer (n) and finds all the prime numbers from 1 to n.
    public class PrimeNumbers
    {
        public int number { get; set; }
        public string Calculate()
        {
            bool prime = false;
            StringBuilder primeNumbers = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                prime = false;

                if (i == 2)
                {
                    prime = true;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                    }
                
                }

                if (prime)
                {
                    primeNumbers.Append(i);
                    primeNumbers.Append(",");
                }
                

                

            }

            return primeNumbers.ToString();
        }
    }
}
