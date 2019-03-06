using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    class StringSort
    {
        public static void DriverMethod()
        {
            int n = 0;
            Int32.TryParse(Console.ReadLine(),out n);
            string[] input = new string[n];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            input = SortStrings(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        private static string[] SortStrings(string[] input)
        {
            for(int i = 0; i < input.Length-1; i++)
            {
                if (Compare(input[i], input[i + 1]))
                {
                    string temp = input[i];
                    input[i] = input[i+1];
                    input[i+1] = temp;
                }
            }
            return input;
        }

        private static bool Compare(string first, string second)
        {
            int LengthFirst = first.Length;
            int LengthSecond = second.Length;
            for (int i = 0; i < LengthFirst && i < LengthSecond; i++)
            {
                if (first[i] > second[i])
                {
                    return true;
                }
                else if (first[i] < second[i])
                {
                    return false;
                }
            }
            if (LengthFirst < LengthSecond)
            {
                return true;
            }
            return false;
        }
    }
}
