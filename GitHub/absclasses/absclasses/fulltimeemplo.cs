using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclasses
{
    public class fulltimeemplo:basemplo
    {
        public int annualsal { get; set; }
        public override int monthlysal()
        {
        return this.annualsal/12;
        }
     
    }
}
