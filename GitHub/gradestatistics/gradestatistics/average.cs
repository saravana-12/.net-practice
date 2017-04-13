using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradestatistics
{
    class average
    {
        public static double averagecalc(int[] grad)
        {
            double avg = 0.0;
            for (int i = 0; i < grad.Length; i++)
            {
                avg = avg + grad[i];
            }
            avg = avg / grad.Length;
            return avg;
        }       
    }
}
