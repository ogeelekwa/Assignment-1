using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_ModeMedian
{
    public partial class Form1 : Form
    {
        List<double> values;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            values = new List<double>();
        }

        void ShowValues()
        {
            lbxValues.Items.Clear();

            for (int i = 0; i < values.Count; i++)
                lbxValues.Items.Add(values[i]);

            lblCount.Text = values.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            values.Clear();
            lbxValues.Items.Clear();

            txtValue.Text = "";
            txtMean.Text = "";
            txtMedian.Text = "";
            txtStandardDev.Text = "";
            txtVariance.Text = "";
            txtValue.Focus();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // This the value that will be added to the text box
            double value = 0.00;
            double sum = 0.00, mean = 0.00;
            double median = 0.00;

            // Check that the user entered a value in the text box
            if (txtValue.Text.Length == 0)
            {
                MessageBox.Show("You must enter a value.", "Measures of Center");
                return;
            }

            try
            {
                // Get the value the user entered
                value = double.Parse(txtValue.Text);
                // Add it to the collection
                values.Add(value);
                // Show the values in the list box
                ShowValues();

                txtValue.Text = "";
                txtValue.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("The value you entered is invalid.",
                                "Probability Distribution");
            }

            // Calculate the total
            for (int i = 0; i < values.Count; i++)
                sum += values[i];
            // Calculate the mean
            mean = sum / values.Count;

            // Get ready to evaluate the median
            // First sort the list
            values.Sort();

            // Find out if the list is odd
            if ((values.Count % 2) == 0)
            {
                double midIndex = values.Count / 2;
                median = (values[(int)(midIndex - 0.5)] +
                      values[(int)(midIndex + 0.5)]) / 2;
            }
            else
                median = values[values.Count / 2];

            // Display the values
            
            txtMean.Text = mean.ToString("F");
            txtMedian.Text = median.ToString("F");
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
