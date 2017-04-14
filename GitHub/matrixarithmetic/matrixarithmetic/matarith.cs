using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixarithmetic
{
    class matarith
    {
        static void Main(string[] args)
        {

            int[,] matrix1,matrix2;

            Console.WriteLine("enter the matrix1 dimension");
            int row1 = Convert.ToInt32(Console.ReadLine());
            int col1 = Convert.ToInt32(Console.ReadLine());                     
            matrix1 = matentry.matent(row1,col1);

            Console.WriteLine("enter the matrix2 dimension");
            int row2 = Convert.ToInt32(Console.ReadLine());
            int col2 = Convert.ToInt32(Console.ReadLine());
            matrix2 = matentry.matent(row2, col2);

            if (row1 == row2 && col1 == col2)
            {
                matadd.matadd1(row1, col1, matrix1, row2, col2, matrix2);
                matsub.matsub1(row1, col1, matrix1, row2, col2, matrix2);
            }
            else
                Console.WriteLine("matrix dimensions must be same to add or subtract");

            if(col1==row2)
            {
                matmul.matmul1(row1, col2,row2, matrix1, matrix2);
            }
            else
                Console.WriteLine("column of first matrix must be equal to row of second matrix formultiplication");
        }
    }
}
