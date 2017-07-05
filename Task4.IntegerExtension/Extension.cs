using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.IntegerExtension
{
    public static class Extension
    {
        ///<summary> Gets a positive integer number and returns the Next Bigger Number consisting from the same didgits </summary>
        /// <param name="number"> Positive number </param>
        /// <param name="time">Time of working in milliseconds</param>
        /// <returns>
        /// Next Bigger Number consisting from the same didgits.
        /// If not exist returns -1.
        /// </returns>
        public static long NextBiggerNumber(long number, out int time)
        {
            DateTime start = DateTime.Now;
            Check(number);
            int n = GetDigitsNumber(number);
            byte[] digits = GetArrayOfDigits(number, n);

            int xIndex = GetFirstDecreasingDigitIndex(digits);
            if (xIndex == -1)
            {
                time = (DateTime.Now - start).Milliseconds;
                return -1;
            }
            int yIndex = GetFirstBiggerDigitIndex(digits, xIndex);
            Swap(xIndex, yIndex, digits);

            long answer = GetNextBigger(digits, xIndex);
            time = (DateTime.Now - start).Milliseconds;
            
            return answer;
        }
        ///<summary> Gets a positive integer number and returns the Next Bigger Number consisting from the same didgits. But works longer, than previous </summary>
        /// <param name="number"> Positive number </param>
        /// <param name="time">Time of working in milliseconds</param>
        /// <returns>
        /// Next Bigger Number consisting from the same didgits.
        /// If not exist returns -1.
        /// </returns>
        public static long NextBiggerNumberLong(long number, out int time)
        {
            DateTime start = DateTime.Now;
            Check(number);
            char[] digits = number.ToString().ToCharArray();
            Array.Sort(digits);
            IStructuralEquatable iArray = digits;

            number = ExhaustiveSearch(iArray, number, digits.Length);

            time = (DateTime.Now - start).Milliseconds;
            return number;
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
        private static long GetNextBigger(byte[] digits, int separator)
        {
            long answer = 0;
            int deg = 1;
            for (int i = separator - 1; i >= 0; i--)
            {
                answer += digits[i] * deg;
                deg *= 10;
            }
            for (int i = separator; i < digits.Length; i++)
            {
                answer += digits[i] * deg;
                deg *= 10;
            }
            return answer;
        }
        private static int GetFirstDecreasingDigitIndex(byte[] digits)
        {
            for (int i = 0; i < digits.Length - 1; i++)
                if (digits[i] > digits[i + 1]) return ++i;
            return -1;
        }
        private static int GetFirstBiggerDigitIndex(byte[] digits, int endIndex)
        {
            for (int i = 0; i < endIndex; i++)
                if (digits[i] > digits[endIndex]) return i;
            return -1;
        }
        private static void Swap(int i, int j, byte[] array)
        {
            byte temp = array[i];
            array[i] = array[j];
            array[j] = temp;

        }
        private static void Check(long number)
        {
            if (number < 1)
                throw new ArgumentException($"{nameof(number)} must be positive");
        }
        private static long ExhaustiveSearch(IStructuralEquatable iArray, long number, int length)
        {
            char[] digits;
            for (long i = number + 1; i <= long.MaxValue; i++)
            {
                digits = i.ToString().ToCharArray();
                if (digits.Length > length) return -1;
                Array.Sort(digits);
                if (iArray.Equals(digits, StructuralComparisons.StructuralEqualityComparer)) return i;
            }
            return -1;
        }
    }
}
