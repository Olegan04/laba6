using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    public class PPD : Fearams
    {
        public PPD(int x = 22000) { 
            this.price = x;
            distance = 1000;
            caliber = 7.62;
            name = "PPD";
        }
    }
}
