using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallel
{
    class parallel1
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10000, x => run());
           // Thread o1 = new Thread(run);
           // o1.Start();

        }
        private static  void run()
        {
            string x = " ";
            for (int i=0;i<10000;i++)
            {
                x = x + "S";
                Console.WriteLine(x);
            }
        }
    }
}
