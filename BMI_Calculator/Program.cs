using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public static class Program
    {
        // For instantation
        public static BMICalculator calculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            calculatorForm = new BMICalculator();
            Application.Run(new SplashScreen());
        }
    }
}
