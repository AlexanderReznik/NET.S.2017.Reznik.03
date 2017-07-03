using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.IntegerExtension
{
    public static class Extension
    {
        public static long NextBiggerNumber(long number)
        {
            ///<summary>
            ///Gets a positive integer number and returns the Next Bigger Number consisting from the same didgits
            /// </summary>
            /// <param name="number">
            /// Positive number
            /// </param>
            /// <returns>
            /// Next Bigger Number consisting from the same didgits.
            /// If not exist returns -1.
            /// </returns>
            if (number < 1)
                throw new ArgumentException("Number must be positive");
            int n = GetDigitsNumber(number);
            byte[] digits = GetArrayOfDigits(number, n);
            bool exists = false;
            int xIndex = -1, yIndex = -1;
            byte x = 10, y = 10;
            for (int i = 0; i < n - 1; i++)
            {
                if (digits[i] > digits[i + 1])
                {
                    exists = true;
                    xIndex = i + 1;
                    x = digits[i + 1];
                    break;
                }
            }
            if (!exists)
                return -1;
            for (int i = xIndex - 1; i >= 0; i--)
            {
                if (digits[i] > x && digits[i] <= y)
                {
                    yIndex = i;
                    y = digits[i];
                }
            }
            digits[xIndex] = y;
            digits[yIndex] = x;
            long answer = 0;
            int deg = 1;
            for (int i = xIndex - 1; i >= 0; i--)
            {
                answer += digits[i] * deg;
                deg *= 10;
            }
            for (int i = xIndex; i < n; i++)
            {
                answer += digits[i] * deg;
                deg *= 10;
            }
            return answer;
        }
        private static int GetDigitsNumber(long x)
        {
            int n = 0;
            while (x > 0)
            {
                n++;
                x /= 10;
            }
            return n;
        }
        private static byte[] GetArrayOfDigits(long x, int n)
        {
            byte[] ar = new byte[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = (byte)(x % 10);
                x /= 10;
            }
            return ar;
        }
    }
}
