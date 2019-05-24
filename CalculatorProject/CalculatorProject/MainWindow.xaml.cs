using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorProject
{

    public partial class MainWindow : Window
    {

        public string currentFormula { get; set; }
        public string fullFormula { get; set; }
        public string powerBaseValue { get; set; }
        public string powerValue { get; set; }
        public bool power { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Calculator Project";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            OutputWindow.Text = "0";
            power = false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentFormula = 1.ToString();
            fullFormula = String.Concat(fullFormula,currentFormula);
            OutputWindow.Text = fullFormula;
            Calculation(fullFormula);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentFormula = 2.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            currentFormula = 3.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }
     

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentFormula = 4.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            currentFormula = 5.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            currentFormula = 6.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            currentFormula = 7.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            currentFormula = 8.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            currentFormula = 9.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            currentFormula = 0.ToString();
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Decimal(object sender, RoutedEventArgs e)
        {
            currentFormula = ".";
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            currentFormula = "+";
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Subtract(object sender, RoutedEventArgs e)
        {
            currentFormula = "-";
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            currentFormula = "/";
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Mod(object sender, RoutedEventArgs e)
        {
            currentFormula = "%";
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            currentFormula = "*";
            fullFormula = String.Concat(fullFormula, currentFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            Calculation(fullFormula);

            if (power == true)
            {
                CalculationPower(powerBaseValue, fullFormula);
            }
        }

        private void Button_Click_SquareRoot(object sender, RoutedEventArgs e)
        {
            int input = Int32.Parse(fullFormula);
            var squareRoot = Math.Sqrt(input);
            OutputWindow.Text = squareRoot.ToString();
        }

        private void Button_Click_Power(object sender, RoutedEventArgs e)
        {
            powerBaseValue = fullFormula;
            fullFormula = "";

            power = true;
        }

        private void Button_Click_Hexadicimal(object sender, RoutedEventArgs e)
        {
            int input = Int32.Parse(fullFormula);            
            fullFormula = Convert.ToString(input, 16);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Factorial(object sender, RoutedEventArgs e)
        {
            decimal baseNumber = Int32.Parse(fullFormula);
            decimal z = 1;
            for (decimal i = 1; i < baseNumber; i++)
            {
                z = (baseNumber - i);
                currentFormula = String.Concat("*", z.ToString());
                fullFormula = String.Concat(fullFormula, currentFormula);
            }

            Calculation(fullFormula);
        }



        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            fullFormula = "";
            currentFormula = 0.ToString();
            OutputWindow.Text = currentFormula;
        }

        private void Calculation(string fullFormula)
        {
            NCalc.Expression e = new NCalc.Expression(fullFormula);
            var x = e.Evaluate();
            OutputWindow.Text = x.ToString();
        }

        private void CalculationPower(string powerBaseValue, string fullFormula)
        {
            var powerResult = Math.Pow(Int32.Parse(powerBaseValue), Int32.Parse(fullFormula));
            power = false;
            OutputWindow.Text = powerResult.ToString();
        }


    }
}
