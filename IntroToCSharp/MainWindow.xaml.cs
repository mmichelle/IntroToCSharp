using System;
using System.Collections.Generic;
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

namespace IntroToCSharp
{
    /// <summary>
    /// Melissa Allee
    /// Intro to C#
    /// Interaction logic for MainWindow.xaml
    /// check input values here
    /// logic for each exercise may be found
    /// in the Assignment# class
    /// </summary>
    public partial class MainWindow : Window
    {
        AssignmentOne assignmentOne;
        
        public MainWindow()
        {
            InitializeComponent();
            assignmentOne = new AssignmentOne();
            UpdatePyramidDisplay();
            textBox_symbol.Text = assignmentOne.one.pyramidSymbol.ToString();
            textBox_size.Text = assignmentOne.one.pyramidSize.ToString();
            textBox_One.Text = assignmentOne.three.numberOne.ToString();
            textBox_two.Text = assignmentOne.three.numberTwo.ToString();
            textBox_three.Text = assignmentOne.three.numberThree.ToString();
            SumLabel.Content = "The sum is " + assignmentOne.three.sum.ToString() + ".";
            ProductLabel.Content = "The product is " + assignmentOne.three.product.ToString() + ".";
        }

        private void textBox_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int iInteger = 0;
                if (int.TryParse(textBox_size.Text, out iInteger))
                {
                    if ((0 == (iInteger % 2)) && (iInteger > 0))
                    {
                        assignmentOne.one.pyramidSize = iInteger;
                        SetTextBoxWarningsWhite();
                    }
                    else
                    {
                        assignmentOne.one.pyramidSize = (iInteger - 1);
                        SetTextBoxWarnings("Even numbers greater than 0 only please.");
                    }
                    UpdatePyramidDisplay();
                }
                else
                    SetTextBoxWarnings("Integers only please.");
            }
        }

        private void textBox_symbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textBox_symbol.Text != "")
                    assignmentOne.one.pyramidSymbol = textBox_symbol.Text[0];
                if (1 < textBox_symbol.Text.Length)
                {
                    SetTextBoxWarnings("Only the first character will be used.");
                }
                else
                {
                    SetTextBoxWarningsWhite();
                }
                UpdatePyramidDisplay();
            }
        }

        private void textBox_symbol_LostFocus(object sender, RoutedEventArgs e)
        {
            if (1 < textBox_symbol.Text.Length)
            {
                SetTextBoxWarnings("Only the first character will be used.");
            }
            else
            {
                SetTextBoxWarningsWhite();
            }
            if (textBox_symbol.Text != "")
                assignmentOne.one.pyramidSymbol = textBox_symbol.Text[0];
            UpdatePyramidDisplay();
        }

        private void SetTextBoxWarningsWhite()
        {
            textBox_warnings.Text = "";
            textBox_warnings.BorderBrush = Brushes.White;
        }
        
        private void SetTextBoxWarnings(string input)
        {
            textBox_warnings.Text = input;
            textBox_warnings.BorderBrush = Brushes.IndianRed;
        }

        private void textBox_size_LostFocus(object sender, RoutedEventArgs e)
        {
            int iInteger = 0;
            if (int.TryParse(textBox_size.Text, out iInteger))
            {
                if ((0 == (iInteger % 2)) && (iInteger > 0))
                {
                    assignmentOne.one.pyramidSize = iInteger;
                    SetTextBoxWarningsWhite();
                }
                else
                {
                    assignmentOne.one.pyramidSize = (iInteger - 1);
                    SetTextBoxWarnings("Even numbers greater than 0 only please.");
                }
                UpdatePyramidDisplay();
            }
            else
                SetTextBoxWarnings("Integers only please.");
        }

        private void UpdatePyramidDisplay()
        {
            richTextBox.Document.Blocks.Clear();
            richTextBox.Document.Blocks.Add(new Paragraph(new Run(assignmentOne.one.pyramid)));
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            int iInteger = 0;
            if (int.TryParse(textBox_age.Text, out iInteger))
            {
                if (iInteger > 0)
                {
                    assignmentOne.two.dogYears = iInteger;
                    dogYearsLabel.Content = "In dog years, you are " + assignmentOne.two.dogYears.ToString() + " years old!";
                }
                else
                    textBox_age.Text = "Please enter a number greater than 0.";
            }
            else
                textBox_age.Text = "Please enter a number greater than 0.";
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int iInteger = 0;
                if (int.TryParse(textBox_age.Text, out iInteger))
                {
                    if (iInteger > 0)
                    {
                        assignmentOne.two.dogYears = iInteger;
                        dogYearsLabel.Content = "In dog years, you are " + assignmentOne.two.dogYears.ToString() + " years old!";
                    } 
                    else
                        textBox_age.Text = "Please enter a number greater than 0.";
                }
                else
                    textBox_age.Text = "Please enter a number.";
            }
        }

        private void textBox_One_TextChanged(object sender, TextChangedEventArgs e)
        {
            float fInteger = 0;
            if (float.TryParse(textBox_One.Text, out fInteger))
            {
                assignmentOne.three.numberOne = fInteger;
                SumLabel.Content = "The sum is " + assignmentOne.three.sum.ToString() + ".";
                ProductLabel.Content = "The product is " + assignmentOne.three.product.ToString() + ".";
                WarningLabel.Content = "";
            }
            else
            {
                WarningLabel.Content = "Please enter a number.";
            }
        }

        private void textBox_two_TextChanged(object sender, TextChangedEventArgs e)
        {
            float fInteger = 0;
            if (float.TryParse(textBox_two.Text, out fInteger))
            {
                assignmentOne.three.numberTwo = fInteger;
                SumLabel.Content = "The sum is " + assignmentOne.three.sum.ToString() + ".";
                ProductLabel.Content = "The product is " + assignmentOne.three.product.ToString() + ".";
                WarningLabel.Content = "";
            }
            else
            {
                WarningLabel.Content = "Please enter a number.";
            }
        }

        private void textBox_three_TextChanged(object sender, TextChangedEventArgs e)
        {
            float fInteger = 0;
            if (float.TryParse(textBox_three.Text, out fInteger))
            {
                assignmentOne.three.numberThree = fInteger;
                SumLabel.Content = "The sum is " + assignmentOne.three.sum.ToString() + ".";
                ProductLabel.Content = "The product is " + assignmentOne.three.product.ToString() + ".";
                WarningLabel.Content = "";
            }
            else
            {
                WarningLabel.Content = "Please enter a number.";
            }
        }

        private void textBox_age_TextChanged(object sender, TextChangedEventArgs e)
        {
            int iInteger = 0;
            if (int.TryParse(textBox_age.Text, out iInteger))
            {
                if (iInteger > 0)
                {
                    assignmentOne.two.dogYears = iInteger;
                    dogYearsLabel.Content = "In dog years, you are " + assignmentOne.two.dogYears.ToString() + " years old!";
                }
                else
                    textBox_age.Text = "Please enter a number greater than 0.";
            }
            else
                textBox_age.Text = "Please enter a number.";
        }
    }
}
