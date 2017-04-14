using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the arguments in the form of: argument1 argument2 operator");
            object[] array;
            array = new object[3];
            JavaArith(array);
        }
        public static void JavaArith(object[] array)
        {
            for (int i = 0; i < 3; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("compute {0} {1} {2}", array[0], array[2], array[1]);
            int op1, op2, answer = 0;
            char op;
            op1 = Convert.ToInt32(array[0]);
            op2 = Convert.ToInt32(array[1]);
            op = Convert.ToChar(array[2]);
            switch (op)
            {
                case '+':
                    answer = op1 + op2;
                    break;
                case '-':
                    answer = op1 - op2;
                    break;
                case '*':
                    answer = op1 * op2;
                    break;
                case '/':
                    answer = op1 / op2;
                    break;
                default:
                    Console.WriteLine("invalid expression");
                    break;
            }
            Console.WriteLine("answer={0}", answer);
        }
    }
}
