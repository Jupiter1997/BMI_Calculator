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
 * Date: August 3, 2017
 * Description: This is a BMI Calculator that Check if an individual has the right MAss index
 * Version 0.1
 */
namespace BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method change the unit of the Height and weight to meter and kilogram
        /// if metric radio is chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void RadMetric_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "m";
            lblWeight.Text = "kg";
        }
        /// <summary>
        /// This method change the unit of the Height and weight to inches and pound
        /// if imperial radio is chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadImperial_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "in";
            lblWeight.Text = "lbs";
        }
        /// <summary>
        /// These are the calculations to get BMI either Metric or imperial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            string[] scale = {"UnderWeight", "Normal", "OverWeight", "Obese" };
            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double bmiResult;

            if (RadMetric.Checked == true)
            {
                bmiResult = Math.Round(weight / (height * height),2);
                if (bmiResult < 18.5)
                {
                    lblScale.Text = scale[0];
                }
                if (24.9 > bmiResult && bmiResult > 18.5)
                {
                    lblScale.Text = scale[1];
                }
                if (29.9 > bmiResult && bmiResult > 25)
                {
                    lblScale.Text = scale[2];
                }
                if (bmiResult > 30)
                {
                    lblScale.Text = scale[3];
                }
                lblBMI.Text = bmiResult.ToString();
            }
            if (RadImperial.Checked == true)
            {
                bmiResult = Math.Round(weight * 703 /(height * height), 2);
                if (bmiResult < 18.5)
                {
                    lblScale.Text = scale[0];
                }
                if (24.9 > bmiResult && bmiResult > 18.5)
                {
                    lblScale.Text = scale[1];
                }
                if (29.9 > bmiResult && bmiResult > 25)
                {
                    lblScale.Text = scale[2];
                }
                if (bmiResult > 30)
                {
                    lblScale.Text = scale[3];
                }
                lblBMI.Text = bmiResult.ToString();
            }
        }
    }
}
