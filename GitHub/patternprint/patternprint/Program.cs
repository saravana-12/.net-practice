using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprint
{
    class pattern
    {
        static void Main(string[] args)
        {
            int size = 10;
            for (int j = 0; j < size; j++)
            {
                for (int k=0;k<j;k++)
                    Console.Write(" ");
                for (int i = 0; i < size - j; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
