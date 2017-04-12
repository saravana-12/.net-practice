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
            string Revstr=(Reverse());
            Console.WriteLine("Reverse  String  Is  {0}", Revstr);
        }
        public static string Reverse()
        {
            string Str, Revstr = "";
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();

            for (int i = Str.Length - 1; i >= 0; i--)
            {

                Revstr = Revstr + Str[i];
            }

           
            return Revstr;
        }
    }
}
