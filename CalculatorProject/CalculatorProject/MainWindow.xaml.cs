using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

        private void Button_Click_Octal(object sender, RoutedEventArgs e)
        {
            int input = Int32.Parse(fullFormula);
            fullFormula = Convert.ToString(input, 8);
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_Binary(object sender, RoutedEventArgs e)
        {
            int input = Int32.Parse(fullFormula);
              string binVal = Convert.ToString(input, 2);
            int bits = 0;
            int bitblock = 4;

            for (int i = 0; i < binVal.Length; i = i + bitblock)
            { bits += bitblock; }

            fullFormula =  binVal.PadLeft(bits, '0');

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

        private void Button_Click_Celcius(object sender, RoutedEventArgs e)
        {
            int fehrenhiut = Int32.Parse(fullFormula);
            fullFormula = Convert.ToString((fehrenhiut - 32) * 5 / 9);
            OutputWindow.Text = fullFormula;

        }

        private void Button_Click_Fahrenheit(object sender, RoutedEventArgs e)
        {
            int celsius = Int32.Parse(fullFormula);
            fullFormula = Convert.ToString((celsius * 9) / 5 + 32);
            OutputWindow.Text = fullFormula;

        }

        private void Button_Click_ToPercent(object sender, RoutedEventArgs e)
        {
            decimal baseNumber = System.Convert.ToDecimal(fullFormula);
            var final = baseNumber.ToString("P", CultureInfo.InvariantCulture);
            fullFormula = final.ToString();
            OutputWindow.Text = fullFormula;
        }

        private void Button_Click_ToDecimal(object sender, RoutedEventArgs e)
        {
            var decimalNum = decimal.Parse(fullFormula.TrimEnd(new char[] { '%', ' ' })) / 100M;
          
            Calculation(decimalNum.ToString());
        }

        private void Button_Click_FromMilligram(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var gram = currentNum / 1000;
            var gramString = String.Concat(gram, " Grams, ");
            var finalFormula = gramString;

            var kilograms = gram / 1000;
            var kiloGramString = String.Concat(kilograms, " Kilo Grams, ");
            finalFormula = String.Concat(finalFormula, kiloGramString);

            var ounce = currentNum / 28349.523;
            var ounceString = String.Concat(ounce, " Ounces, ");
            finalFormula = String.Concat(finalFormula, ounceString);

            var pound = currentNum / 453592.37;
            var poundString = String.Concat(pound, " Pounds");
            finalFormula = String.Concat(finalFormula, poundString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromGram(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var milliGram = currentNum * 1000;
            var milliGramString = String.Concat(milliGram, " Milligrams, ");
            var finalFormula = milliGramString;

            var kilograms = currentNum / 1000;
            var kiloGramString = String.Concat(kilograms, " Kilo Grams, ");
            finalFormula = String.Concat(finalFormula, kiloGramString);

            var ounce = currentNum / 28.35;
            var ounceString = String.Concat(ounce, " Ounces, ");
            finalFormula = String.Concat(finalFormula, ounceString);

            var pound = currentNum / 453.592;
            var poundString = String.Concat(pound, " Pounds");
            finalFormula = String.Concat(finalFormula, poundString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromKilogram(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var milliGram = currentNum * 1e+6;
            var milliGramString = String.Concat(milliGram, " Milligrams, ");
            var finalFormula = milliGramString;

            var grams = currentNum * 1000;
            var gramString = String.Concat(grams, " grams, ");
            finalFormula = String.Concat(finalFormula, gramString);

            var ounce = currentNum * 35.274;
            var ounceString = String.Concat(ounce, " Ounces, ");
            finalFormula = String.Concat(finalFormula, ounceString);

            var pound = currentNum * 2.205;
            var poundString = String.Concat(pound, " Pounds");
            finalFormula = String.Concat(finalFormula, poundString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromOunce(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var milliGram = currentNum * 28349.523;
            var milliGramString = String.Concat(milliGram, " Milligrams, ");
            var finalFormula = milliGramString;

            var grams = currentNum * 28.35;
            var gramString = String.Concat(grams, " Grams, ");
            finalFormula = String.Concat(finalFormula, gramString);

            var kiloGram = currentNum / 35.274;
            var kiloGramString = String.Concat(kiloGram, " Kilo Grams, ");
            finalFormula = String.Concat(finalFormula, kiloGramString);

            var pound = currentNum / 16;
            var poundString = String.Concat(pound, " Pounds");
            finalFormula = String.Concat(finalFormula, poundString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromPound(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var milliGram = currentNum * 453592.37;
            var milliGramString = String.Concat(milliGram, " Milligrams, ");
            var finalFormula = milliGramString;

            var grams = currentNum * 453.592;
            var gramString = String.Concat(grams, " Grams, ");
            finalFormula = String.Concat(finalFormula, gramString);

            var kiloGram = currentNum / 2.205;
            var kiloGramString = String.Concat(kiloGram, " Kilo Grams, ");
            finalFormula = String.Concat(finalFormula, kiloGramString);

            var ounce = currentNum * 16;
            var ounceString = String.Concat(ounce, " Ounces");
            finalFormula = String.Concat(finalFormula, ounce);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromMillimetres(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var centimeters = currentNum / 10;
            var centiMetersString = String.Concat(centimeters, " Centimeters, ");
            var finalFormula = centiMetersString;

            var meters = currentNum / 1000;
            var metersString = String.Concat(meters, " Meters, ");
            finalFormula = String.Concat(finalFormula, metersString);

            var kilometers = currentNum / 1e+6;
            var kiloMetersString = String.Concat(kilometers, " Kilometers, ");
            finalFormula = String.Concat(finalFormula, kiloMetersString);

            var inches = currentNum / 25.4;
            var inchString = String.Concat(inches, " Inches, ");
            finalFormula = String.Concat(finalFormula, inchString);

            var feet = currentNum / 304.8;
            var feetString = String.Concat(feet, " Feet");
            finalFormula = String.Concat(finalFormula, feetString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromCentimeters(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var millimeters = currentNum * 10;
            var MellimetersString = String.Concat(millimeters, " Mellimeters, ");
            var finalFormula = MellimetersString;

            var meters = currentNum / 100;
            var metersString = String.Concat(meters, " Meters, ");
            finalFormula = String.Concat(finalFormula, metersString);

            var kilometers = currentNum / 100000;
            var kiloMetersString = String.Concat(kilometers, " Kilometers, ");
            finalFormula = String.Concat(finalFormula, kiloMetersString);

            var inches = currentNum / 2.54;
            var inchString = String.Concat(inches, " Inches, ");
            finalFormula = String.Concat(finalFormula, inchString);

            var feet = currentNum / 30.48;
            var feetString = String.Concat(feet, " Feet");
            finalFormula = String.Concat(finalFormula, feetString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromMeters(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var millimeters = currentNum * 1000;
            var MellimetersString = String.Concat(millimeters, " Mellimeters, ");
            var finalFormula = MellimetersString;

            var centimeters = currentNum * 100;
            var centimetersString = String.Concat(centimeters, " Centimeters, ");
            finalFormula = String.Concat(finalFormula, centimetersString);

            var kilometers = currentNum / 1000;
            var kiloMetersString = String.Concat(kilometers, " Kilometers, ");
            finalFormula = String.Concat(finalFormula, kiloMetersString);

            var inches = currentNum * 39.37;
            var inchString = String.Concat(inches, " Inches, ");
            finalFormula = String.Concat(finalFormula, inchString);

            var feet = currentNum * 3.281;
            var feetString = String.Concat(feet, " Feet");
            finalFormula = String.Concat(finalFormula, feetString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromKilometers(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var millimeters = currentNum * 1e+6;
            var MellimetersString = String.Concat(millimeters, " Mellimeters, ");
            var finalFormula = MellimetersString;

            var centimeters = currentNum * 100000;
            var centimetersString = String.Concat(centimeters, " Centimeters, ");
            finalFormula = String.Concat(finalFormula, centimetersString);

            var meters = currentNum * 1000;
            var metersString = String.Concat(meters, " Meters, ");
            finalFormula = String.Concat(finalFormula, metersString);

            var inches = currentNum * 39370.079;
            var inchString = String.Concat(inches, " Inches, ");
            finalFormula = String.Concat(finalFormula, inchString);

            var feet = currentNum * 3280.84;
            var feetString = String.Concat(feet, " Feet");
            finalFormula = String.Concat(finalFormula, feetString);

            OutputWindow.Text = finalFormula;

        }

        private void Button_Click_FromInches(object sender, RoutedEventArgs e)
        {
            double currentNum = System.Convert.ToDouble(fullFormula);

            var millimeters = currentNum * 25.4;
            var MellimetersString = String.Concat(millimeters, " Mellimeters, ");
            var finalFormula = MellimetersString;

            var centimeters = currentNum * 2.54;
            var centimetersString = String.Concat(centimeters, " Centimeters, ");
            finalFormula = String.Concat(finalFormula, centimetersString);

            var meters = currentNum / 39.37;
            var metersString = String.Concat(meters, " Meters, ");
            finalFormula = String.Concat(finalFormula, metersString);

            var kilometers = currentNum / 39370.079;
            var kmString = String.Concat(kilometers, " Kilometers, ");
            finalFormula = String.Concat(finalFormula, kmString);

            var feet = currentNum / 12;
            var feetString = String.Concat(feet, " Feet");
            finalFormula = String.Concat(finalFormula, feetString);

            OutputWindow.Text = finalFormula;

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
