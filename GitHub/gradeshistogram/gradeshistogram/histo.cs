using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeshistogram
{
    class histo
    {
        static void Main(string[] args)
        {
            int[] grad = gradesentry.gradesentry1();
            histoprint.histoprint1(grad);
        }


    }
}
