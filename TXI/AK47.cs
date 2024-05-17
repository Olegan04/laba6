using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    public class AK47 : Fearams
    {
        public AK47(int x = 20000) { 
            this.price = x;
            distance = 1000;
            caliber = 7.62;
            name = "AK47";
        }
    }
}
