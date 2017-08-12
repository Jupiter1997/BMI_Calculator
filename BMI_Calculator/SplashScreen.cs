using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Marvin Jupiter Vargas
 * Student No. : 300901192
 * Date: August 11, 2017
 * Description: This is a BMI Calculator that Check if an individual has the right MAss index
 * Version 0.2: Added SplashTimer
 */

namespace BMI_Calculator
{
    public partial class SplashScreen : Form
    {
        //Public Properties
        public BMICalculator CalculatorForm
        {
          get
         {
             return Program.calculatorForm;
         }
          
        }

        public SplashScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The Countdown timer for the main form to "load"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTime_Tick(object sender, EventArgs e)
        {
            this.CalculatorForm.Show();
            this.Hide();
            SplashTime.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
