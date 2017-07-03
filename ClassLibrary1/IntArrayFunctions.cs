using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFunctions
{
    public static class IntArrayFunctions
    {
        public static int GetSumMedian(int[] array)
        {
            ///<summary>
            ///Finds the first element in array, 
            ///for which the sum of right subarray equals
            ///the sum of left subarray
            ///</summary>
            ///<param name="array">
            ///Any integer array you want
            /// </param>
            /// <returns>
            ///Index of the first element in array, 
            ///for which the sum of right subarray equals
            ///the sum of left subarray
            /// </returns>
            if (array == null)
                return -1;
            if (array.Length == 0)
                return -1;
            long sum = 0;
            foreach (int x in array)
                sum += x;
            long leftSum = 0;
            long rightSum = sum;
            int answer = -1;
            for (int i = 0; i < array.Length; i++)
            {
                rightSum -= array[i];
                if (i > 0)
                    leftSum += array[i - 1];
                if (leftSum == rightSum)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
    }
}
