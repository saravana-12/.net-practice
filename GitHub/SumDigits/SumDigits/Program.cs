using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("entert the number of digits");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the {0} digit positive integer string to be summed",n);
            int[] array;
            array = new int[n];
            string s;
            s = Convert.ToString(Console.ReadLine());
            for (int i=0;i<n; i++ )
            {
                array[i] =Convert.ToInt32( s[i]);
            }
            Console.WriteLine("ASCII Values are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", array[i]); 
            }
            int sum=0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + array[i]-48;
            }
            Console.WriteLine("sum={0}", sum);
        }
    }
}
