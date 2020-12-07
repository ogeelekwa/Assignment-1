using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_PoundstoKilo
{
    public partial class Form1 : Form
    {
        double Lbs, Kg;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbs = 0; Kg = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                Kg = Convert.ToDouble(textBox1.Text);
                Lbs = Kg / 2.2;
                textBox1.Text = Lbs.ToString();
            }
            else
            {
                textBox1.Text = "NOT VALID";
            }
        }
    }
}
