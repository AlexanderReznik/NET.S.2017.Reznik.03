using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryOperations
{
    public class MixingInt
    {
        /// <summary>
        /// Inserts bits(from i to j) from the second number to the first using logic operators and masks
        /// </summary>
        /// <param name="first">The first number</param>
        /// <param name="second">The second number</param>
        /// <param name="i">Start position of insertion</param>
        /// <param name="j">Finish position of insertion</param>
        /// <returns></returns>
        public static int InsertionBits(int first, int second, int i, int j)
        {
            Check(i, j);
            int mask1, mask2;
            CreateMasks(i, j, out mask1, out mask2);

            return (first & mask1) | (second & mask2);
        }
        private static void CreateMasks(int i, int j, out int mask1, out int mask2)
        {
            short bits = 31;
            int max = int.MaxValue;
            mask1 = (max >> (bits - j - 1)) ^ -1 | (max >> (bits - i));
            mask2 = -1 ^ mask1;
        }
        private static void Check(int i, int j)
        {
            if (i > 30 || i < 0) throw new ArgumentOutOfRangeException($"{nameof(i)} is out of range.");
            if (j > 30 || j < 0) throw new ArgumentOutOfRangeException($"{nameof(j)} is out of range.");
            if (j < i) throw new ArgumentException($"{nameof(i)} cannot be less than {nameof(j)}");
        }
    }
}
