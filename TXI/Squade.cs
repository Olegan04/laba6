using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXI
{
    internal class Squade
    {
        private Soldier[] soldier;
        public void setSoldier(int n, string[] s, Weapon[][] weapons)
        {
            for (int i = 0; i < n; i++)
            {
                soldier[i].setName(s[i]);
                for (int j = 0; j < weapons[i].Length; j++)
                {
                    soldier[i].addWeapone(weapons[i][j]);
                }
            }

        }
        public int moreArmed()
        {
            int sumPrices = 0;
            for (int i = 0; i < soldier.Length; i++)
            {
                sumPrices += soldier[i].getPrice();
            }
            return sumPrices;
        }
    }
}
