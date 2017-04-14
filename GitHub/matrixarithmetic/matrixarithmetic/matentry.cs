using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixarithmetic
{
    class matentry
    {
        public static int[,] matent(int row,int col)
        {
             int[,] mat;
            mat = new int[row, col];
            Console.WriteLine("enter the elements of matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the matrix is");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0}\t",mat[i,j]);
                }
                Console.WriteLine();
            }
            return mat;

        }
    }
}
