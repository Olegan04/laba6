using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXI;

namespace AAAA
{
    public partial class NewWeapon : Form
    {
        Form1 f1 = new Form1();
        public NewWeapon(Form1 f1)
        {
            InitializeComponent();
            comboBox1.Items.Add("Fearam");
            comboBox1.Items.Add("Cold");
            this.f1 = f1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "Fearam")
            {
                comboBox2.Items.AddRange(new string[] { "AK47", "PD", "PPD" });
            }
            if (comboBox1.SelectedItem.ToString() == "Cold")
            {
                comboBox2.Items.AddRange(new string[] { "Knife" });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.SetWeapon(comboBox2.SelectedItem.ToString(), Convert.ToInt32(textBox1.Text));
            f1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
    }
}
