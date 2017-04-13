using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productable
{
    class productable1
    {
        static void Main(string[] args)
        {
            int sum = 0,t=1,u=1;
            for (int row = 0; row <= 9; row++)
            {
                for (int col = 0; col <= 9; col++)
                {
                    if (row == 0 && col == 0)
                        Console.Write("* \t");
                    else if (row == 0 && col != 1)
                    {
                    
                        Console.Write("{0} \t",t);
                        t++;
                    }
                    else if (row !=1 && col == 0)
                    {

                        Console.Write("{0} \t",u);
                        u++;
                    }
                    else if(row==1)
                        Console.Write("_\t");
                    else if (col == 1)
                        Console.Write("|\t");
                    else
                    {
                        sum = (row-1) * (col-1);
                        Console.Write("{0} \t ", sum);
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
