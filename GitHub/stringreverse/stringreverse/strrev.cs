using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringreverse
{
    class strrev
    {
        static void Main(string[] args)
        {
           string outp= reverse();
            Console.WriteLine(outp);
        }
    public static string reverse()
        {
            string revstr="";
            Console.WriteLine("enter string");
          string  instr = Convert.ToString(Console.Read());
            for (int i = instr.Length - 1; i >= 1; i--)
            {
                revstr = revstr + instr[instr.Length - i];

            }
            Console.WriteLine("reverse string");
            Console.WriteLine(revstr);
            return revstr;
        }
    }
}
