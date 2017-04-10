using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclasses
{
    public class partimeemplo : basemplo
    {
        public int hours { get; set; }
        public int perhour { get; set; }
        public override int monthlysal()
        {
            return this.hours * this.perhour;
        }
    }
}
