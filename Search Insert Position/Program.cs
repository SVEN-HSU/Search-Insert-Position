using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {-1, 1, 3, 5, 6 ,9};
            Console.WriteLine(@"A[]= {-1, 1, 3, 5, 6 ,9}");
            Console.WriteLine("search 5 : " + searchInsert(A, 5));
            Console.WriteLine("search 2 : " + searchInsert(A, 2));
            Console.WriteLine("search 7 : " + searchInsert(A, 7));
            Console.WriteLine("search 0 : " + searchInsert(A, 0));
            Console.Read();
        }

        static int searchInsert(int[] A, int target)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i].Equals(target))
                {
                    return i;
                }

                if ((A[i] <= target) && (A[i + 1] >= target))
                {
                    return (i + 1);
                }
            }

            if (target <= A[0])
            {
                return 0;
            }

            if (target >= A[A.Length - 1])
            {
                return A.Length;
            }

            return -1;
        }
    }
}
