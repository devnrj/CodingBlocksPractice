using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    class BitonicArrayMaxLen
    {
        public static int[] InputArray(string[] input)
        {
            int[] values = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                Int32.TryParse(input[i], out values[i]);
            }
            return values;
        }

        public static void DriverMethod()
        {
            int t = 0;
            Int32.TryParse(Console.ReadLine(), out t);
            for (int i = 0; i < t; i++)
            {
                int n = 0;
                string[] input = new string[n];
                Int32.TryParse(Console.ReadLine(), out n);
                input = Console.ReadLine().Split(' ');
                int[] values = InputArray(input);
                int result = CountLenOfBitonicSubarray(values);
                Console.WriteLine(result);
            }
        }

        private static int CountLenOfBitonicSubarray(int[] values)
        {
            int[] inc = FindIncreasingCount(values);
            int[] dec = FindDecreasingCount(values);
            int max = int.MinValue;
            for (int i = 0; i < values.Length; i++)
            {
                int currMax = inc[i] + dec[i] - 1;
                max = Math.Max(currMax, max);
            }
            return max;
        }

        private static int[] FindIncreasingCount(int[] values)
        {
            int[] inc = new int[values.Length];
            if (inc.Length > 0)
            {
                inc[0] = 1;
            }
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > values[i - 1])
                {
                    inc[i] = inc[i - 1] + 1;
                }
                else
                {
                    inc[i] = 1;
                }

            }
            return inc;
        }

        private static int[] FindDecreasingCount(int[] values)
        {
            int[] dec = new int[values.Length];
            if (dec.Length > 0)
            {
                dec[dec.Length - 1] = 1;
            }
            for (int i = values.Length - 2; i >= 0; i--)
            {
                if (values[i] > values[i + 1])
                {
                    dec[i] = dec[i + 1] + 1;
                }
                else
                {
                    dec[i] = 1;
                }

            }
            return dec;
        }
    }
}