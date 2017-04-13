using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bardisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            bar();
        }



        public static void bar()
        {
            int[] bars;           
            Console.WriteLine("enter the number of bars");
            int n = Convert.ToInt32(Console.ReadLine());
            bars = new int[n];
            Console.WriteLine("enter the {0} bar counts",n);
            for(int i=0;i<n;i++)
            {
                bars[i] = Convert.ToInt32(Console.ReadLine());  
            }
            for(int j=0;j<n;j++)
            {
                for(int k=0;k<bars[j];k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }

        }
    }
}
