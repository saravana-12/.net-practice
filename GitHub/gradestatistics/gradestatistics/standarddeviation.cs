using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradestatistics
{
    class standarddeviation
    {
        public static double stdcalc(int[]grad,double avg)
        {
            double x = 0.0,stdev=0.0;
            for(int i=0; i<grad.Length;i++)
            {
                x = x + (grad[i] * grad[i]);
            }
            x = x / grad.Length;
            stdev = Math.Sqrt(x - (avg * avg));
            return stdev;
        

        }
    }
}
