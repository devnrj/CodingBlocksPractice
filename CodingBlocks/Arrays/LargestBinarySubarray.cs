using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    class LargestBinarySubarray
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
                FindLargestBinarySubarray(values);
            }
        }

        public static void FindLargestBinarySubarray(int[] values)
        {
            Dictionary<int,int> map= new Dictionary<int,int>();
            int length = values.Length;
            int count = 0; 
            int maxLen = 0; 
            int end = -1;
            int begin = 0;

            for (int i = 0; i < length; i++)
            {
                values[i] = (values[i] == 0) ? -1 : 1;
            }

            
            for (int i = 0; i < length; i++)
            {
                
                count += values[i];

                
                if (count == 0)
                {
                    maxLen = i + 1;
                    end = i;
                }

               
                if (map.ContainsKey(count + length))
                {
                    if (maxLen < i - map[count + length])
                    {
                        maxLen = i - map[count + length];
                        end = i;
                    }
                }else 
                {
                    map[count + length] = i;
                }
            }

            for (int i = 0; i < length; i++)
            {
                values[i] = (values[i] == -1) ? 0 : 1;
            }

            int x = end - maxLen + 1;

            if(maxLen != 0)
            {
                Console.WriteLine(x + " " + end);
            }else
            {
                Console.WriteLine("None");
            }
        }
    }
}
