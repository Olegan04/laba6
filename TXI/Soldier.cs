using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    internal class Soldier
    {
        private string name;
        List<Weapon> weapons;
        public void setName(string s)
        {
            name = s;
        }
        public void addWeapone(Weapon weapone)
        {
            weapons.Add(weapone);
        }
        public int getPrice()
        {
            int price = 0;
            for (int i = 0; i < weapons.Count(); i++)
            {
                price += weapons[i].getPrice();
            }
            return price;
        }
    }
}
