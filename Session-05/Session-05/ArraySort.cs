using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ArraySort
    {
        public string Sort()
        {
            int[] arrayToSort = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            int temp = 0;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j < arrayToSort.Length - i - 1; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        // swap temp and arr[i]
                        temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
                }
            }

            StringBuilder sortedArray = new StringBuilder();

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                sortedArray.Append(arrayToSort[i]);
                sortedArray.Append(",");
            }

            return sortedArray.ToString();
        }
    }
}
