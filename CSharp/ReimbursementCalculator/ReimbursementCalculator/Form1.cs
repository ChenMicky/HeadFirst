using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReimbursementCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, amountOwed;
        double reimburseRate = .39;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)start.Value;
            endingMileage = (int)end.Value;

            if (startingMileage > endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate Mileage");
            }
            else
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }



    }
}
