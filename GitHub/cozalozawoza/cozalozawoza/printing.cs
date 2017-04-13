using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozalozawoza
{
    class printing
    {
        static void Main(string[] args)
        {
            printings();
        }
        public static void printings()
        {
            int lowerbound = 1, upperbound = 110;
            for (int i =lowerbound; i<= upperbound;i++)
            {
                if (i%3 == 0)
                    Console.Write("coza\t");
                else if (i%5==0)
                    Console.Write("loza\t");
                else if (i%7 == 0)
                    Console.Write("woza\t");
                else
                    Console.Write("{0}\t",i);

            }
        }
    }
}
