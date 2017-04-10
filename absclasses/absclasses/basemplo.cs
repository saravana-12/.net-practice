using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclasses
{
    public abstract class basemplo
    {
        public int id { get; set; }
        public string firname { get; set; }
        public string lasname { get; set; }
        public string getfullname()
        {
            return this.firname +" "+ lasname;
        }
        public abstract int monthlysal();
         
    }
}
