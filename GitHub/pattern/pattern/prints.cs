using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    class prints
    {
        static void Main(string[] args)
        {
             print();
        }
        public static void print()
        {
            char[,] a;
            a = new char[7,4];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i,j] = '*';
                }
            }

                    for (int i =0;i<7;i++)
            {
                for(int j=0;j<4;j++)
                {

                    if (i == 0 && j != 0)
                    {
                        Console.Write("{0}", a[i, j]);
                        Console.WriteLine();
                    }

                    else if (i == 1 || i == 2 && j == 0)
                    {
                        Console.WriteLine("{0}", a[i, j]);
                        Console.WriteLine();
                    }
                    else if (i == 3 && (j == 1 || j == 2))
                    {
                        Console.WriteLine("{0}", a[i, j]);
                        Console.WriteLine();
                    }
                    else if (j == 3 && (i == 4 || i == 5))
                    {
                        Console.WriteLine("{0}", a[i, j]);
                        Console.WriteLine();
                    }
                    else if (i == 6 && j != 3)
                    {
                        Console.WriteLine("{0}", a[i, j]);
                        Console.WriteLine();
                    }

                    }
            }

        }
    }
}
