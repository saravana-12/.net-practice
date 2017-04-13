using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradestatistics
{
    class grade1
    {
        static void Main(string[] args)
        {
          int[]grad= grades.gradesentry();
            Console.WriteLine("average={0}",average.averagecalc(grad));          
            Console.WriteLine("maximum grade={0}",grad.Max());
            Console.WriteLine("minimum grade={0}",grad.Min());
            Console.WriteLine("median={0}", median.mediancalc(grad));
            Console.WriteLine("standard deviation={0}",standarddeviation.stdcalc(grad, median.mediancalc(grad)));
        }
    }
}
