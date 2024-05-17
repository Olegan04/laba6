using TXI;
int main()
    {
        AK47 ak = new AK47();
        PD pd = new PD(); 
        PPD ppd = new PPD();
        Knife knife = new Knife();
        Squade squade = new Squade();
        string[] s = { "Ivan", "Misha", "Oleg", "Lev", "Danil" };
        Weapon[][] weapons = new Weapon[5][];
        weapons[0][0] = ak; weapons[0][1] = knife;
        weapons[1][0] = pd; weapons[1][1] = ak;
        weapons[2][0] = ppd;
        weapons[3][0] = ppd; weapons[3][1] = knife;
        weapons[4][0] = pd;
        squade.setSoldier(5, s, weapons);
        int price = squade.moreArmed();
        return 0;
    }