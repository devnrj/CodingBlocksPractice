using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    public class BiggestNumber
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
                Comparison<string> comparer = new Comparison<string>(MyComparer);
                Array.Sort(input,comparer);
                string number = CovertToString(input);
                Console.WriteLine(number);
            }
        }

        private static string CovertToString(string[] input)
        {
            String number = "";
            foreach(string s in input)
            {
                number += s;
            }
            return number;
        }

        private static int MyComparer(String x, String y)
        {
            string xstr = x.ToString();
            string ystr = y.ToString();
            int result = 0;
            if (String.Compare(xstr + ystr, ystr + xstr)<0)
            {
                result = 1;
            }else if (String.Compare(xstr + ystr, ystr + xstr) > 0)
            {
                result = -1;
            }
            return result;
        }

        private static string GenerateBiggestNumber(string[] input)
        {
            String temp = BiggerNumber(input[0], input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                temp = BiggerNumber(temp + input[i], input[i] + temp);
            }
            return temp;
        }

        private static string BiggerNumber(string xy,string yx)
        {
            string number = "";
            if(String.Compare(xy,yx)>0 )
            {
                number = xy;
            }else if(String.Compare(xy, yx) < 0)
            {
                number = yx;
            }else
            {
                number=xy;
            }
            return number;
        }
    }
}
