using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class fact
    {
        static void Main(string[] args)
        {
           fact1(5);
        }
        public static int fact1(int f)
        {
            int factorial = 1;
            for (int i = 1; i <= f; i++)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("factorail of {0} is {1} ", f, factorial);
            return 0;

        }
    }
}
