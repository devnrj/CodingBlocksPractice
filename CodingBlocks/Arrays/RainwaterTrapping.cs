using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    class RainwaterTrapping
    {
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
                int result = CountTrappedWater(values,n);
                Console.WriteLine(result);
            }
        }

        private static int CountTrappedWater(int[] values,int size)
        {
            int[] leftMax = FindLeftMaximum(values);
            int[] rightMax = FindRightMaximum(values);
            int count = 0;
            for(int i = 0; i < size; i++)
            {
                count += Math.Min(leftMax[i], rightMax[i]) - values[i];
            }
            return count;
        }

        private static int[] FindLeftMaximum(int[] values)
        {
            int[] leftMax = new int[values.Length];
            leftMax[0] = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], values[i]);
            }
            return leftMax;
        }

        private static int[] FindRightMaximum(int[] values)
        {
            int[] rightMax = new int[values.Length];
            rightMax[rightMax.Length-1] = values[values.Length-1];
            for (int i = values.Length-2;i>=0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], values[i]);
            }
            return rightMax;
        }

        public static int[] InputArray(string[] input)
        {
            int[] values = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                Int32.TryParse(input[i], out values[i]);
            }
            return values;
        }
    }
}
