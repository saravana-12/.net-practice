using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            fulltimeemplo fe = new fulltimeemplo()
            {
                id = 1234,
                firname = "Sara",
                lasname = "vana",
                annualsal = 900000
            };
            Console.WriteLine(fe.getfullname());
            Console.WriteLine(fe.monthlysal());

            partimeemplo pe = new partimeemplo()
            {
                id = 1234,
                firname = "sa",
                lasname = "na",
                hours = 5,
                perhour=500
          
            };
            Console.WriteLine(pe.getfullname());
            Console.WriteLine(pe.monthlysal());

        }

    }
}
