using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class collect
    {
        static void Main(string[] args)
        {
            customer c1 = new customer()
            {
                id = 100,
                name = "sar",
                salary = 10000
            };
            customer c2 = new customer()
            {
                id = 101,
                name = "sri",
                salary = 12000
            };
            customer c3 = new customer()
            {
                id = 102,
                name = "roop",
                salary = 13000
            };
            List<customer> cust = new List<customer>(3);
            cust.Add(c1);
            cust.Add(c2);
            cust.Add(c3);
            for(int i=0; i< cust.Count; i++)
            {
                customer c = cust[i];
                Console.WriteLine("{0},{1},{2}",c.id,c.name,c.salary);
            }


        }
        public class customer
        {
          public int id { get; set;}
           public string name { get; set; }
           public double salary { get; set; } 
        }

    }
}
