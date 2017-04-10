using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class bsort
    {
            public static int[] sort(int[] a)
            {
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
                return a;
            }
        }
    }
