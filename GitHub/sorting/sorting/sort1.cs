using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class sort1
    {
        public static void Main(string[] args)
        {
            int[] a = { 2, 3, 1, 9, 8, 4 };
            Console.WriteLine("given array");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            int[] b = bsort.sort(a);
            Console.WriteLine("sorted array");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
   
}
