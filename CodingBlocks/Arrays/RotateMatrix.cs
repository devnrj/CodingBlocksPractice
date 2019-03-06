using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.Arrays
{
    public class RotateMatrix
    {
        public static void PrintMatrix(int[,] matrix, int rowLength, int colLength)
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //public static void Main()
        //{
        //    int n = 0;
        //    string str = Console.ReadLine();
        //    Int32.TryParse(str, out n);
        //    int[,] matrix = new int[n, n];

        //    //populating matrix
        //    for (int i = 0; i < n; i++)
        //    {
        //        string[] input = Console.ReadLine().Split(' ');
        //        for (int j = 0; j < n; j++)
        //        {
        //            Int32.TryParse(input[j], out matrix[i, j]);
        //        }
        //    }
            
        //    //transpose of matrix
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = i; j < n; j++)
        //        {
        //            int temp = matrix[i, j];
        //            matrix[i, j] = matrix[j, i];
        //            matrix[j, i] = temp;
        //        }
        //    }
        //    //columnwise swapping
        //    for (int i = 0; i < n / 2; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            int temp = matrix[i, j];
        //            matrix[i, j] = matrix[n - i - 1, j];
        //            matrix[n - i - 1, j] = temp;
        //        }
        //    }
        //    PrintMatrix(matrix, n, n);
        //}
    }
}
