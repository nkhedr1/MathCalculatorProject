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


        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Calculator Project";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            OutputWindow.Text = "0";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentFormula = 1.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentFormula = 2.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            currentFormula = 3.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }
     

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentFormula = 4.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            currentFormula = 5.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            currentFormula = 6.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            currentFormula = 7.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            currentFormula = 8.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            currentFormula = 9.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            currentFormula = 0.ToString();
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            currentFormula = "+";
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Subtract(object sender, RoutedEventArgs e)
        {
            currentFormula = "-";
            fullFormula = String.Concat(currentFormula, fullFormula);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            Calculation(fullFormula);
        }

        private void Calculation(string fullFormula)
        {
            NCalc.Expression e = new NCalc.Expression(fullFormula);
            e.Evaluate().ToString();
            OutputWindow.Text = e.Evaluate().ToString();
        }

    }
}
