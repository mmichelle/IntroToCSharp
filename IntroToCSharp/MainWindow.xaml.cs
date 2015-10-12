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
        AssignmentTwo assignmentTwo;
        AssignmentThree assignmentThree;
        
        public MainWindow()
        {
            InitializeComponent();
            assignmentOne = new AssignmentOne();
            assignmentTwo = new AssignmentTwo();
            assignmentThree = new AssignmentThree();
            UpdatePyramidDisplay();
            textBox_symbol.Text = assignmentOne.one.pyramidSymbol.ToString();
            textBox_size.Text = assignmentOne.one.pyramidSize.ToString();
            textBox_One.Text = assignmentOne.three.numberOne.ToString();
            textBox_two.Text = assignmentOne.three.numberTwo.ToString();
            textBox_three.Text = assignmentOne.three.numberThree.ToString();
            SumLabel.Content = "The sum is " + assignmentOne.three.sum.ToString() + ".";
            ProductLabel.Content = "The product is " + assignmentOne.three.product.ToString() + ".";
            m_editThreeEntry.Text = "";
            for (int ii = 0; ii < (int)Titles.eTitles.TOTAL_TITLES; ii++)
                m_listTitles.Items.Add(Titles.m_aStrTitles[ii]);
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

        private void m_editThreeEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                assignmentTwo.one.input = m_editThreeEntry.Text;

                m_editFloatAvgOut.Text = assignmentTwo.one.floatingAverageString();

                m_editIntAvgOut.Text = assignmentTwo.one.integerAverageString();

                m_editFloatDiffOut.Text = assignmentTwo.one.floatDifferenceString();
            }
        }

        private void m_editThreeEntry_LostFocus(object sender, RoutedEventArgs e)
        {
            assignmentTwo.one.input = m_editThreeEntry.Text;

            m_editFloatAvgOut.Text = assignmentTwo.one.floatingAverageString();

            m_editIntAvgOut.Text = assignmentTwo.one.integerAverageString();

            m_editFloatDiffOut.Text = assignmentTwo.one.floatDifferenceString();
        }

        private void m_listTitles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int input = m_listTitles.SelectedIndex;
            if (-1 != input)
                assignmentTwo.two.title = Titles.m_aStrTitles[input];
            else
                assignmentTwo.two.title = "";

            if ("" != m_editFullName.Text)
                UpdateNameOutputWindow();
        }

        private void m_editFullName_LostFocus(object sender, RoutedEventArgs e)
        {
            assignmentTwo.two.input = m_editFullName.Text;
            UpdateNameOutputWindow();
        }

        private void UpdateNameOutputWindow()
        {
            m_textOutput.Text = assignmentTwo.two.outputText();
        }

        private void m_editFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Enter == e.Key)
            {
                assignmentTwo.two.input = m_editFullName.Text;
                UpdateNameOutputWindow();
            }
        }

        private void m_btnSubmitIntegers_Click(object sender, RoutedEventArgs e)
        {
            bool anyErrors = false;
            int iMinimum = 0;
            int iMaximum = 0;
            if (int.TryParse(m_editMinimumInteger.Text, out iMinimum))
            {
                assignmentThree.setMinimum(iMinimum);
            }
            else
            {
                anyErrors = true;
                m_staticAsThreeEOneReport.Text = "Please use integers only!";
            }
            if (int.TryParse(m_editMaximumInteger.Text, out iMaximum))
            {
                assignmentThree.setMaximum(iMaximum);
            }
            else
            {
                anyErrors = true;
                m_staticAsThreeEOneReport.Text = "Please use integers only!";
            }

            if (!anyErrors)
            {
                m_staticAll.Text = assignmentThree.allResult();
                m_staticEven.Text = assignmentThree.evenResult();
                m_staticOdd.Text = assignmentThree.oddResult();
            }
            else
            {
                m_staticAll.Text = "";
                m_staticEven.Text = "";
                m_staticOdd.Text = "";
            }
        }

        private void m_richTextAsThreeETwo_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void resetCount()
        {
            int count = m_listBoxAsThreeETwo.Items.Count - 1;
            for (int i = count; i > 0; i--)
            {
                m_listBoxAsThreeETwo.SelectedIndex = i;
                m_listBoxAsThreeETwo.Items.RemoveAt(i);
            }
            assignmentThree.clearInput();
        }

        private void m_editAsThreeETwoInput_KeyDown(object sender, KeyEventArgs e)
        {
            int iInput = 0;
            if (Key.Enter == e.Key)
            {
                if (m_editAsThreeETwoStatus.Text == "See final results below.")
                {
                    resetCount();
                    m_editAsThreeETwoStatus.Text = "";
                    return;
                }
                if (int.TryParse(m_editAsThreeETwoInput.Text, out iInput))
                {
                    if ((0 < iInput) && (10 >= iInput))
                    {
                        assignmentThree.setInput(iInput);
                        m_editAsThreeETwoStatus.Text = "";
                        m_listBoxAsThreeETwo.SelectedIndex = iInput;
                        String listItem = "";
                       // String listItem = ((ListBoxItem)(m_listBoxAsThreeETwo.SelectedItem)).Content.ToString();

                        listItem = (iInput.ToString()+ "  \t   " + (assignmentThree.getInput(iInput)-1).ToString());
                        if (m_listBoxAsThreeETwo.Items.Contains(listItem))
                        {
                            m_listBoxAsThreeETwo.SelectedItem = listItem;
                            listItem = (iInput.ToString() + "  \t   " + assignmentThree.getRow(iInput));
                            m_listBoxAsThreeETwo.Items[m_listBoxAsThreeETwo.SelectedIndex] = listItem;
                        }
                        else
                        {
                            m_listBoxAsThreeETwo.Items.Add((iInput.ToString() + "  \t   " + assignmentThree.getRow(iInput)));
                        }
                        
                    }
                    else
                        m_editAsThreeETwoStatus.Text = "Your number must be between 1 and 10.";
                }
                else if ( "q" == m_editAsThreeETwoInput.Text)
                {
                    m_editAsThreeETwoStatus.Text = "See final results below.";
                }
                else
                {
                    m_editAsThreeETwoStatus.Text = "Your number must be between 1 and 10.";
                }
                m_editAsThreeETwoInput.Text = "";
            }
        }
    }
}
