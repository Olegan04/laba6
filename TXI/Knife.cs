using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    public class Knife : Cold
    {
        public Knife(int x = 550) { 
            this.price = x;
            name = "Knife";
            length = 0.2;
        }
    }
}
