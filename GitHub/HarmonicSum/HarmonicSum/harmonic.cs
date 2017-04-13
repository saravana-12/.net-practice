using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSum
{
    class harmonic
    {
        static void Main(string[] args)
        {
            harmoniccalc();
        }
        public static void harmoniccalc()
        {
            Console.WriteLine("enter the largest denominator");
            int n = Convert.ToInt32(Console.Read());
            double sumL2R=1.0 ;
            double sumR2L = 1.0;
            for (double i=2;i<=n;i++)
            {
                sumL2R = sumL2R + (1 / i);
            }
            Console.WriteLine("hormonic sum from left to right = {0}", sumL2R);
            for (double i = n; i >1; i--)
            {
                sumR2L = sumR2L + (1 / i);
            }
            Console.WriteLine("hormonic sum from right to left = {0}", sumR2L);
        }
    }
}
