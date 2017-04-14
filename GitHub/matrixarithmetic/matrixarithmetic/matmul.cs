using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixarithmetic
{
    class matmul
    {
        public static int[,] matmul1(int row1,int col2,int row2,int[,] matrix1,int[,]matrix2)
        {
            int sum = 0;
            int[,] mulresult;
            mulresult = new int[row1, col2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    for (int k = 0; k < row2; k++)
                    {
                        sum = sum + matrix1[i, k] * matrix2[k, j];
                    }
                    mulresult[i, j] = sum;
                    sum = 0;
                }
            }
            Console.WriteLine("multiplication result");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(mulresult[i, j]);
                }
                Console.WriteLine();
            }
            return mulresult;
        }
    }
}
