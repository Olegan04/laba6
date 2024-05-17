namespace AAAA
{
    using TXI;

    public partial class Form1 : Form
    {
        List<Weapon> weapons = new List<Weapon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetWeapon();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void GetWeapon()
        {
            listBox1.Items.Clear();
            if (weapons.Count == 0)
            {
                listBox1.Items.Add("Список пуст");
            }
            for (int i = 0; i < weapons.Count; i++)
            {
                listBox1.Items.Add(weapons[i].geName() + " " + weapons[i].getPrice());
            }
            getSum();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewWeapon newWeapon = new NewWeapon(this);
            newWeapon.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          if(listBox1.SelectedIndex >= 0)
            {
                ChangeData changeData = new ChangeData(this, listBox1.SelectedIndex);
                changeData.Show();
                this.Hide();
            }
        }
        public void SetWeapon(string weaponName, int price)
        {
            Weapon weapon = new Weapon();
            if (weaponName == "AK47")
            {
                weapon = new AK47(price);
            }
            if (weaponName == "PD")
            {
                weapon = new PD(price);
            }
            if (weaponName == "PPD")
            {
                weapon = new PPD(price);
            }
            if (weaponName == "Knife")
            {
                weapon = new Knife(price);
            }
            weapons.Add(weapon);
            GetWeapon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                weapons.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
                getSum();
            }
            
        }
        public void changePrice(int index, int price)
        {
            weapons[index].changePrice(price);
            GetWeapon();
        }
        public void getSum()
        {
            int sum = 0;
            for(int i = 0; i < weapons.Count; i++)
            {
                sum += weapons[i].getPrice();
            }
            label1.Text = "Общая сумма закипки оружия: " + sum;
        }
    }
}
