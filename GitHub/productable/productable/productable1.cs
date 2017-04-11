using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productable
{
    class productable1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int row = 1; row <= 9; row++)
            {
                for (int col = 1; col <= 9; col++)
                {
                    sum = row * col;
                    Console.Write("{0} ", sum);
                }
                Console.WriteLine();
            }
        }
    }
}
