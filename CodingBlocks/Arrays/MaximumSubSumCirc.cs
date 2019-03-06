using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    class MaximumSubSumCirc
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
                Int32.TryParse(Console.ReadLine(), out n);
                string[] input = Console.ReadLine().Split(' ');
                int[] values = InputArray(input);
                int sum = SumArray(values);
                int max = KadaneAlgo(InvertPolarity(values));
                int result = sum + max;
                Console.WriteLine(result);

            }
        }

        public static int[] InvertPolarity(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (-1) * values[i];
            }
            return values;
        }

        private static int SumArray(int[] values)
        {
            int sum = 0;
            foreach (int x in values)
            {
                sum = sum + x;
            }
            return sum;
        }

        private static int KadaneAlgo(int[] values)
        {
            int max = int.MinValue;
            int currentMax = 0;
            for (int i = 0; i < values.Length; i++)
            {
                currentMax = currentMax + values[i];
                if (currentMax < 0)
                {
                    currentMax = 0;
                }
                if (max < currentMax)
                {
                    max = currentMax;
                }
            }
            return max;
        }
    }
}
