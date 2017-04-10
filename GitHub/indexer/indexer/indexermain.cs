using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class indexermain
    {
        public static void Main()
        {
            indexer1 ind = new indexer1(100, "sara", 22, "run");
            Console.WriteLine("id:" + ind[0]);
            Console.WriteLine("name:"+ind[1]);
            Console.WriteLine("age:"+ind[2]);
            Console.WriteLine("quote:"+ind[3]);
            Console.WriteLine();
            Console.WriteLine();
            ind[0] = 101;
            ind[1] = "san";
            Console.WriteLine("id:" + ind[0]);
            Console.WriteLine("name:" + ind[1]);
            Console.WriteLine("age:" + ind[2]);
            Console.WriteLine("quote:" + ind[3]);


        }
    }
}
