using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.BinarySearch
{
    class LowerUpperBound
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
            int n = 0;
            Int32.TryParse(Console.ReadLine(), out n);
            string[] input = Console.ReadLine().Split(' ');
            int[] values = InputArray(input);
            int t = 0;
            Int32.TryParse(Console.ReadLine(), out t);
            for (int i = 0; i < t; i++)
            {
                int x = 0;
                Int32.TryParse(Console.ReadLine(), out x);
                LinearSearch(values, x);
            }
        }
        private static void LinearSearch(int[] values, int x)
        {
            int lower = -1, upper = -1;
            for ( int j = 0; j < values.Length; j++)
            {
                if (values[j] == x)
                {
                    if (lower ==-1)
                    {
                        lower = j;
                        upper = j;
                    }
                    upper = j;
                }
            }
            Console.WriteLine(lower + " " + upper);
        }
    }
}
