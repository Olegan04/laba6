using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    public class PD : Fearams
    {
        public PD(int x = 1500) { 
            this.price = x;
            distance = 1000;
            caliber = 7.62;
            name = "PD";
        }
    }
}
