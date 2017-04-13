using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacai
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new fibonacai.Program();
            int fib = p.fibon(20);
        }
        public int fibon(int i)
        {
            int fn = 0;
            int f1 = 1;
            int f2 = 1;
            int sum = 2;
            Console.WriteLine("the first {0} fibonaci numbers are ", i);
            Console.Write("1 \t 1\t");
            for (int j = 0; j <= i-3; j++)
            {
                fn = f1 + f2;
                f2 = f1;
                f1 = fn;
                Console.Write("{0} \t", fn);
                sum = sum + fn;
            }
            double avg;
            avg = Convert.ToDouble(sum / i);
            Console.WriteLine("average={0}", avg);


            return fn;

        }


    }
}
