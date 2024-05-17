using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAA
{
    public partial class ChangeData : Form
    {
        Form1 form1 = new Form1();
        int index;
        public ChangeData(Form1 form, int x)
        {
            InitializeComponent();
            form1 = form;
            index = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.changePrice(index, Convert.ToInt32(textBox1.Text));
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
