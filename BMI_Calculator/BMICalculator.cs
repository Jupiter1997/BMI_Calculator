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
 * Version 0.3: Added a reset button
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
                    pbUnder.Visible = true;
                    pbNormal.Visible = false;
                    pbOver.Visible = false;
                    pbObese.Visible = false;
                }
                if (24.9 > bmiResult && bmiResult > 18.5)
                {
                    lblScale.Text = scale[1];
                    pbUnder.Visible = false;
                    pbNormal.Visible = true;
                    pbOver.Visible = false;
                    pbObese.Visible = false;
                }
                if (29.9 > bmiResult && bmiResult > 25)
                {
                    lblScale.Text = scale[2];
                    pbUnder.Visible = false;
                    pbNormal.Visible = false;
                    pbOver.Visible = true;
                    pbObese.Visible = false;
                }
                if (bmiResult > 30)
                {
                    lblScale.Text = scale[3];
                    pbUnder.Visible = false;
                    pbNormal.Visible = false;
                    pbOver.Visible = false;
                    pbObese.Visible = true;
                }
                lblBMI.Text = bmiResult.ToString();
            }
            if (RadImperial.Checked == true)
            {
                bmiResult = Math.Round(weight * 703 /(height * height), 2);
                if (bmiResult < 18.5)
                {
                    lblScale.Text = scale[0];
                    pbUnder.Visible = true;
                    pbNormal.Visible = false;
                    pbOver.Visible = false;
                    pbObese.Visible = false;
                }
                if (24.9 > bmiResult && bmiResult > 18.5)
                {
                    lblScale.Text = scale[1];
                    pbUnder.Visible = false;
                    pbNormal.Visible = true;
                    pbOver.Visible = false;
                    pbObese.Visible = false;
                }
                if (29.9 > bmiResult && bmiResult > 25)
                {
                    lblScale.Text = scale[2];
                    pbUnder.Visible = false;
                    pbNormal.Visible = false;
                    pbOver.Visible = true;
                    pbObese.Visible = false;
                }
                if (bmiResult > 30)
                {
                    lblScale.Text = scale[3];
                    pbUnder.Visible = false;
                    pbNormal.Visible = false;
                    pbOver.Visible = false;
                    pbObese.Visible = true;
                }
                lblBMI.Text = bmiResult.ToString();
            }
        }

       
        /// <summary>
        /// This is the reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            
            lblBMI.Text = "0000";
            lblScale.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            
            pbUnder.Visible = true;
            pbNormal.Visible = true;
            pbOver.Visible = true;
            pbObese.Visible = true;

        }
    }
}
