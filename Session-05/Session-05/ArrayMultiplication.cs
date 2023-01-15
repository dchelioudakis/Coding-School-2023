using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ArrayMultiplication
    {
        //4. Write a C# program to multiply all values from Array1 with all values from Array2 and display the results in a new Array.
        public string Get()
        {
            int[] arrayOne = new int[] { 2, 4, 9, 12 };
            int[] arrayTwo = new int[] { 1, 3, 7, 10 };
            int[] arrayNew = new int[16];

            int counter = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    arrayNew[counter] = arrayOne[i] * arrayTwo[j];
                    counter++;
                }
            }

            StringBuilder multiplicationArray = new StringBuilder();

            for (int i = 0; i < arrayNew.Length; i++)
            {
                multiplicationArray.Append(arrayNew[i]);
                multiplicationArray.Append(",");
            }

            return multiplicationArray.ToString();
        }
    }
}
