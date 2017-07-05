using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFunctions
{
    public static class IntArrayFunctions
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
        public static int GetSumMedian(int[] array)
        {
            CheckArray(array);
            long sum = GetArraySum(array), leftSum = 0, rightSum = sum;
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
        private static void CheckArray(int[] a)
        {
            if (a == null)
                throw new ArgumentNullException();
            if (a.Length == 0)
                throw new ArgumentException("Empty array");
        }
        private static long GetArraySum(int[] a)
        {
            long sum = 0;
            foreach (int x in a) sum += x;
            return sum;
        }
    }
}
