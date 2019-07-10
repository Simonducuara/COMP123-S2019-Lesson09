using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Building_a_Calculator
{
    public partial class CalcuatorForm : Form
    {
        /// <summary>
        /// this is the constructor for the calculator form
        /// </summary>
        public CalcuatorForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is a shared event handler for the calculatorbutton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int ButtonValue;
            bool Result = int.TryParse(TheButton.Text ,out ButtonValue);

            if (Result)
            {
                ResultLabel.Text = TheButton.Text;
            }
            else
            {
                ResultLabel.Text = "Not a number (NAN)";
            }
            


        }
    }
}
