using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradestatistics
{
    public class grades
    {

        public static int[] gradesentry()
        {
            int[] grad;
            Console.WriteLine("enter the number of students");
            int n = Convert.ToInt32(Console.ReadLine());
            grad = new int[n];
            Console.WriteLine("enter the grades of {0} students", n);
            for (int i = 0; i <n; i++)
            {
                grad[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= (n - 1); i++)
            {
                Console.WriteLine("grade of student {0} is {1}",i+1,grad[i]);
            }
            return grad;

        }
    }
}

