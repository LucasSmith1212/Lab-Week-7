/// Lab 7 Project 1
/// File Name: lab7project1.cs
/// @author: Lucas Smith
/// Date: 10/11/2021
/// 
/// Problem Statement: Simple GUI that acts as a mini-calculator
/// 
/// Overall Plan:
/// 1. Create GUI Elements
/// 2. Use a private onClick statement to run based on the inputs into listBox and the two textboxes
/// 3. Using switch statement, figure out which operation to run based on the input in the listBox
/// 4. Output the result of the operation in the resultBox

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

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int Operation = listBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftTextBox.Text);
                decimal rightHand = Convert.ToDecimal(rightTextBox.Text);
                decimal result = 0;
                switch (Operation)
                {
                    case 0:
                        result = leftHand + rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultTextBox.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No Operation Selected.");
                        break;
                }
            } catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Cannot Divide by Zero");
            }
        }
    }
}
