using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int text = 10 + Convert.ToInt32(textBoxPrice.Text);
            textBoxPrice.Text = text.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPrice.Text)>10)
            {
                int text = -10 + Convert.ToInt32(textBoxPrice.Text);
                textBoxPrice.Text = text.ToString();
            }
        }
    }
}
