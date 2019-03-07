using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBlocks.BinarySearch
{
    class BookAllocation
    {
        public static int[] InputArray(string[] input)
        {
            int[] books = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                Int32.TryParse(input[i], out books[i]);
            }
            return books;
        }

        public static void DriverMethod()
        {
            int t = 0;
            Int32.TryParse(Console.ReadLine(), out t);
            for (int i = 0; i < t; i++)
            {
                int noOfBooks = 0, noOfStudents = 0;
                string[] sizes = Console.ReadLine().Split(' ');
                Int32.TryParse(sizes[0], out noOfBooks);
                Int32.TryParse(sizes[1], out noOfStudents);
                string[] input = new string[noOfBooks];
                input = Console.ReadLine().Split(' ');
                int[] books = InputArray(input);
                int result = AllocatePages(books, noOfBooks, noOfStudents);
                Console.WriteLine(result);
            }
        }

        private static int AllocatePages(int[] books, int noOfBooks, int noOfStudents)
        {
            int count = 0;
            if (noOfStudents > noOfBooks)
            {
                return -1;
            }

            for(int i = 0; i < noOfBooks; i++)
            {
                count += books[i];
            }

            int low = 0, high = count;
            int result = int.MaxValue;
            while (low <= high)
            {
                int mid = (low+high) / 2;
                if (IsDistributionValid(books, noOfBooks, noOfStudents, mid))
                {
                    result = Math.Min(result, mid);
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return result;
        }

        private static bool IsDistributionValid(int[] books, int noOfBooks, int noOfStudents, int mid)
        {
            int studentsRequired = 1;
            int currPages = 0;
            for(int i = 0; i < noOfBooks; i++)
            {
                if (books[i] > mid)
                {
                    return false;
                }
                if (currPages + books[i] > mid)
                {
                    studentsRequired++;
                    currPages = books[i];
                    if (studentsRequired > noOfStudents)
                    {
                        return false;
                    }
                }
                else
                {
                    currPages += books[i];
                }
            }
            return true;
        }
    }
}
