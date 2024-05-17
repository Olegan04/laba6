using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    public class Weapon
    {
        protected int price;
        protected string name="";

        public int getPrice()
        {
            return price;
        }
        public string geName()
        {
            return name;
        }
        public void changePrice(int x)
        {
            price = x;
        }
    }
}
