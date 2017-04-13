using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradestatistics
{
    class median
    {
        public static double mediancalc(int[] grad)
        {
            double med = 0.0;
            int[] a = grad;
            for (int i = 1; i < a.Length - 2; i++)
            {
                for (int j = 0; j < a.Length - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            int n = a.Length;
            if (n % 2 == 0)
                med = (a[(n / 2)] + a[(n / 2) + 1]);
            else
                med = a[n / 2];
            return med;
        }
    }
}
