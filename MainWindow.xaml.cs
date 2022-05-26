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

namespace AdvancedCalculator
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



        string firstNumber;
        string secondNumber;
        string storedInput=null;
        char operationSign;
        double resultNumber;
        

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            answerbox1.Text = "0";
            storedInput = "";
            firstNumber = string.Empty;
            secondNumber = string.Empty;

        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {

            if (answerbox1.Text == "0"|| storedInput== "")
            {

                answerbox1.Text = "1";
                storedInput += "1";

            }
            else
            {
                answerbox1.Text +="1";
                storedInput += "1";


            }

        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {

            if (answerbox1.Text == "0" || storedInput == "")
            {

                answerbox1.Text = "2";
                storedInput += "2";

            }
            else
            {
                answerbox1.Text += "2";
                storedInput += "2";


            }

        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0" || storedInput == "")
            {

                answerbox1.Text = "3";
                storedInput += "3";

            }
            else
            {
                answerbox1.Text += "3";
                storedInput += "3";


            }

        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0" || storedInput == "")
            {

                answerbox1.Text = "4";
                storedInput += "4";

            }
            else
            {
                answerbox1.Text += "4";
                storedInput += "4";


            }

        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {

            if (answerbox1.Text == "0" || storedInput == "")
            {
                answerbox1.Text = "5";
                storedInput += "5";
            }
            else
            {
                answerbox1.Text += "5";
                storedInput += "5";


            }


        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0" || storedInput == "")
            {
                answerbox1.Text = "6";
                storedInput += "6";
            }
            else
            {
                answerbox1.Text += "6";
                storedInput += "6";


            }

        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0" || storedInput == "")
            {
                answerbox1.Text = "7";
                storedInput += "7";
            }
            else
            {
                answerbox1.Text += "7";
                storedInput += "7";


            }


        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0" || storedInput == "")
            {
                answerbox1.Text = "8";
                storedInput += "8";
            }
            else
            {
                answerbox1.Text += "8";
                storedInput += "8";


            }

        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0" || storedInput == "")
            {
                answerbox1.Text = "9";
                storedInput += "9";
            }
            else
            {
                answerbox1.Text += "9";
                storedInput += "9";


            }

        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (answerbox1.Text == "0"&&storedInput!="")
            {






            }
            else if (storedInput!="")
            {

                answerbox1.Text += "0";
                storedInput += "0";



            } 
            else
            {


                answerbox1.Text = "0";
                storedInput += "0";


            }




        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            operationSign = '+';
            firstNumber = storedInput;
            storedInput = "";
            answerbox1.Text = firstNumber;

        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {

            operationSign = '-';
            firstNumber = storedInput;
            storedInput = "";
            answerbox1.Text = firstNumber;


        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {

            operationSign = '*';
            firstNumber = storedInput;
            storedInput = "";
            answerbox1.Text = firstNumber; 




        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            operationSign = '/';
            firstNumber = storedInput;
            storedInput = "";
            answerbox1.Text = firstNumber;


        }

        private void btn_decimal_Click(object sender, RoutedEventArgs e)
        {

            if (!answerbox1.Text.Contains("."))
            {
                answerbox1.Text += ".";
                storedInput += ".";
            }
            else if (answerbox1.Text.Contains("."))
            {
                MessageBox.Show("There is already a decimal.", "Error!");

            }
            else
            {

                MessageBox.Show("There is already a decimal.", "Error!");


            }



        }


        private void btn_percent_Click(object sender, RoutedEventArgs e)
        {

            double percentpreValue = Convert.ToDouble(answerbox1.Text);
            double percentValue = (percentpreValue / 100);
            storedInput = percentValue.ToString();
            answerbox1.Text = percentValue.ToString();


        }


        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = storedInput;
            double finalNum1 = 0;
            double finalNum2 = 0;

            try
            {
                finalNum1 = Convert.ToDouble(firstNumber);
                finalNum2 = Convert.ToDouble(secondNumber);

                if (operationSign == '+')
                {

                    resultNumber = (finalNum1 + finalNum2);
                    answerbox1.Text = resultNumber.ToString();
                    storedInput = "";
                    secondNumber = "";
                    firstNumber = "";



                }
                else if (operationSign == '-')
                {

                    resultNumber = (finalNum1 - finalNum2);
                    answerbox1.Text = resultNumber.ToString();
                    storedInput = "";
                    secondNumber = "";
                    firstNumber = "";


                }

                else if (operationSign == '*')
                {


                    resultNumber = (finalNum1 * finalNum2);
                    answerbox1.Text = resultNumber.ToString();
                    storedInput = "";
                    secondNumber = "";
                    firstNumber = "";



                }

                else if (operationSign == '/')
                {

                    resultNumber = (finalNum1 / finalNum2);
                    answerbox1.Text = resultNumber.ToString();
                    storedInput = "";
                    secondNumber = "";
                    firstNumber = "";




                }
            }

            catch (FormatException)
            {

                MessageBox.Show("The previous calcuation has been finshed! Starting a new one.", "Notice");
                answerbox1.Text = "0";
                storedInput = "";
                secondNumber = "";
                firstNumber = "";




            }
















        }

        
    }
}
