using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeshistogram
{
    class histoprint
    {
        public static void histoprint1(int[] grad)
        {
            int row = 0, col = 0;
            int col1 = 0;
            int col2 = 10;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0;
            for (int i = 0; i < grad.Length; i++)
            {
                if (grad[i] >= 0 && grad[i] <= 10)
                    c1++;
                else if (grad[i] > 10 && grad[i] <= 20)
                    c2++;
                else if (grad[i] > 20 && grad[i] <= 30)
                    c3++;
                else if (grad[i] > 30 && grad[i] <= 40)
                    c4++;
                else if (grad[i] > 40 && grad[i] <= 50)
                    c5++;
                else if (grad[i] > 50 && grad[i] <= 60)
                    c6++;
                else if (grad[i] > 60 && grad[i] <= 70)
                    c7++;
                else if (grad[i] > 70 && grad[i] <= 80)
                    c8++;
                else if (grad[i] > 80 && grad[i] <= 90)
                    c9++;
                else if (grad[i] > 90 && grad[i] <= 100)
                    c10++;
            }
            for (row = 0; row <= 10; row++)
            {
                for (col = 0; col < 100; col++)
                {
                    if (col == 0)
                    {                       
                        Console.Write("{0}", col1);
                        col1 = col1 + 10;                        
                    }

                    if (col==1)
                        Console.Write("-");

                    if (col==2)
                    {
                        
                        Console.Write("{0}", col2);
                        col2 = col2 + 10;                        
                    }

                    if (col==3)
                        Console.Write(":");     
                    else if (col>=3)
                    {
                        if(c1>0 && row==0)
                        {
                            Console.Write("*");
                            c1--;
                        }
                        else if (c2 > 0 && row==1)
                        {
                            Console.Write("*");
                            c2--;
                        }
                        else if (c3 > 0 && row==2)
                        {
                            Console.Write("*");
                            c3--;
                        }
                        else if (c4 > 0 && row ==3)
                        {
                            Console.Write("*");
                            c4--;
                        }
                        else if (c5 > 0 && row ==4)
                        {
                            Console.Write("*");
                            c5--;
                        }
                        else if (c6 > 0 && row ==5)
                        {
                            Console.Write("*");
                            c6--;
                        }
                        else if (c7 > 0 && row ==6)
                        {
                            Console.Write("*");
                            c7--;
                        }
                        else if (c8 > 0 && row ==7)
                        {
                            Console.Write("*");
                            c8--;
                        }
                        else if (c9 > 0 && row ==8)
                        {
                            Console.Write("*");
                            c9--;
                        }
                        else if (c10 > 0 && row ==9)
                        {
                            Console.Write("*");
                            c10--;
                        }
                    }                           
                }
                Console.WriteLine();              
            }
           
        }
    }
}
