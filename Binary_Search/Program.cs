using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int f = 0, l = arr.Length - 1, target = 2;

            int result = binarySearch(arr, f, l, target);

            Console.WriteLine($"index: {result}");
        }

        public static int binarySearch(int[] arr, int first, int last, int target)
        {
            if(last >= first)
            {
                int mid = first + (last - first)  / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                else if (arr[mid] > target)
                {
                    return binarySearch(arr, first, mid - 1, target);
                }

                else
                {
                    return binarySearch(arr, mid + 1, last, target);
                }
            }

            else
            {
                return -1;
            }
        }
    }
}
