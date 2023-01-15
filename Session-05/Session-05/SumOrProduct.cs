using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
   // 2. Write a C# program that asks the user for an integer (n) and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.
    public class SumOrProduct
    {

        public int number { get; set; }

        public int Sum()
        {
            int mySum=0;

            for (int i = 1; i <= number; i++)
            {
                mySum += i;
            }

            return mySum;
        }

        public int Product()
        {
            int myProduct=1;

            for (int i = 1; i <= number; i++)
            {
                myProduct *= i;
            }

            return myProduct;
        }
    }
}
