using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixarithmetic
{
    class matadd
    {
        public static int[,] matadd1(int row1, int col1,int[,] matrix1,int row2,int col2,int[,] matrix2)
        {
            int[,] addresult;
            addresult = new int[row1, col1];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                   addresult[i,j]= matrix1[i,j]+matrix2[i,j];
                }
            }
            Console.WriteLine("addition result");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(addresult[i, j]);  
                }
                Console.WriteLine();
            } 
            return addresult;


        }
    }
}
