using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ammar Hashlamoun

//Calculator Assignment
namespace Calculator
{
    public partial class MainCalc : Form
    {
        public MainCalc()
        {
            InitializeComponent();
        }
        private void OperationClick(object sender, EventArgs e)
        {
            Button curButton = (Button)sender;
            AnswerBox.Text += curButton.Text;
        }
        private void zero_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text+"0");
        }
        private void one_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text= (AnswerBox.Text+"1");
        }

        private void two_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text+"2");
        }

        private void three_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text+"3");
        }

        private void four_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text+"4");
        }

        private void five_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text + "5");
        }

        private void six_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text + "6");
        }

        private void seven_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text + "7");
        }
        private void eight_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text + "8");
        }


        private void nine_Click(object sender, EventArgs e) //Inputing button clicks into the AnswerBox
        {
            AnswerBox.Text = (AnswerBox.Text + "9");
        }

        private void Plus_Click(object sender, EventArgs e) 
        {
            if (AnswerBox.Text.Contains("-") | AnswerBox.Text.Contains("+") | AnswerBox.Text.Contains("/") | AnswerBox.Text.Contains("x") | AnswerBox.Text.Contains("%"))
            {
                MessageBox.Show("Please only do one operation at a time");  //Making sure that only one operation is used at a time
            } else {
                AnswerBox.Text = (AnswerBox.Text + "+"); //Inputing button clicks into the AnswerBox
            }


        }

        private void subtract_Click(object sender, EventArgs e) 
        {
            if (AnswerBox.Text.Contains("-") | AnswerBox.Text.Contains("+") | AnswerBox.Text.Contains("/") | AnswerBox.Text.Contains("x") | AnswerBox.Text.Contains("%"))
            {
                MessageBox.Show("Please only do one operation at a time");   //Making sure that only one operation is used at a time
            }
            else
            {
                AnswerBox.Text = (AnswerBox.Text + "-"); //Inputing button clicks into the AnswerBox
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (AnswerBox.Text.Contains("-") | AnswerBox.Text.Contains("+") | AnswerBox.Text.Contains("/") | AnswerBox.Text.Contains("x") | AnswerBox.Text.Contains("%"))
            {
                MessageBox.Show("Please only do one operation at a time"); //Making sure that only one operation is used at a time
            }
            else
            {
                AnswerBox.Text = (AnswerBox.Text + "x"); //Inputing button clicks into the AnswerBox
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (AnswerBox.Text.Contains("-") | AnswerBox.Text.Contains("+") | AnswerBox.Text.Contains("/") | AnswerBox.Text.Contains("x") | AnswerBox.Text.Contains("%"))
            {
                MessageBox.Show("Please only do one operation at a time"); //Making sure that only one operation is used at a time
            }
            else
            {
                AnswerBox.Text = (AnswerBox.Text + "/"); //Inputing button clicks into the AnswerBox
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (AnswerBox.Text.Contains("-") | AnswerBox.Text.Contains("+") | AnswerBox.Text.Contains("/") | AnswerBox.Text.Contains("x") | AnswerBox.Text.Contains("%"))
            {
                MessageBox.Show("Please only do one operation at a time"); //Making sure that only one operation is used at a time
            }
            else
            {
                AnswerBox.Text = (AnswerBox.Text + "%"); //Inputing button clicks into the AnswerBox
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            int SignLocation = 0; // Making a variable for later use
            if (AnswerBox.Text.Contains("+"))
            {
                SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("+"));  //Assigning a value to the variable so that it can be used later to know where to convert string to float
            }
            if (AnswerBox.Text.Contains("-"))     
            {
                SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("-")); // ''
            }
            if (AnswerBox.Text.Contains("x"))
            {
                SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("x")); // ''
            }
            if (AnswerBox.Text.Contains("/"))
            {
                SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("/")); // ''
            }
            if (AnswerBox.Text.Contains("%"))
            {
                SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("%")); // ''
            }
            float Number1 = float.Parse(AnswerBox.Text.Substring(0, SignLocation)); //Converting AnswerBox to variables
            float Number2 = float.Parse(AnswerBox.Text.Substring(SignLocation + 1)); //Converting AnswerBox to variables
            if (AnswerBox.Text.Contains("+")) //Checks for needed operation
            {
                AnswerBox.Text = Convert.ToString(Addition(Number1, Number2)); //Calls function and converts it to string. shows it in a messagebox
            }
            if (AnswerBox.Text.Contains("-")) //Checks for needed operation
            {
                AnswerBox.Text = Convert.ToString(Subtraction(Number1, Number2));
            }
            if (AnswerBox.Text.Contains("x")) //Checks for needed operation
            {
                AnswerBox.Text = Convert.ToString(Multiplication(Number1, Number2));
            }
            if (AnswerBox.Text.Contains("/")) //Checks for needed operation
            {
                AnswerBox.Text = Convert.ToString(Division(Number1, Number2));
            }
            if (AnswerBox.Text.Contains("%")) //Checks for needed operation
            {
                AnswerBox.Text = Convert.ToString(Mod(Number1, Number2));
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = ""; //Clears the AnswerBox by setting it equal to ""
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (AnswerBox.Text.Length > 0)
            {
                AnswerBox.Text = AnswerBox.Text.Substring(0, AnswerBox.Text.Length - 1); //Sets answer box to answerbox - the last character
            }
        }

        private void period_Click(object sender, EventArgs e)
        {
            if (AnswerBox.Text.Contains(".") == false)   //Inputing button clicks into the AnswerBox. This also insures that the . button is not misused
            {
                AnswerBox.Text = (AnswerBox.Text + ".");  //Inputing button clicks into the AnswerBox. This also insures that the . button is not misused
            }
            else if (AnswerBox.Text.Contains("-") | AnswerBox.Text.Contains("+") | AnswerBox.Text.Contains("/") | AnswerBox.Text.Contains("x") | AnswerBox.Text.Contains("%")) //allows second variable/number to use the .
            {
                int SignLocation = 0;
                if (AnswerBox.Text.Contains("+"))
                {
                    SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("+")); //uses similar system to the equal button
                }
                if (AnswerBox.Text.Contains("-"))
                {
                    SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("-")); //''
                }
                if (AnswerBox.Text.Contains("x"))
                {
                    SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("x")); //''
                }
                if (AnswerBox.Text.Contains("/"))
                {
                    SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("/")); //''
                }
                if (AnswerBox.Text.Contains("%"))
                {
                    SignLocation = Convert.ToInt32(AnswerBox.Text.IndexOf("%")); //''
                }
                if (AnswerBox.Text.Substring(SignLocation).Contains(".") == false) //if . not already in there, you can put it
                {
                    AnswerBox.Text = AnswerBox.Text + ".";
                }

            }
        }
        static float Addition(float num1, float num2) //Making operation functions to be called when needed
        {
            return num1 + num2; 
        }  //Addition Function/Method
        static float Subtraction(float num1, float num2) //Making operation functions to be called when needed
        {
            return num1 - num2;
        } //Subtraction Function/Method
        static float Multiplication(float num1, float num2) //Making operation functions to be called when needed
        {
            return num1 * num2;
        } //Multiplication Function/Method
        static float Division(float num1, float num2) //Making operation functions to be called when needed
        {
            return num1 / num2;
        } //Division Function/Method
        static float Mod(float num1, float num2) //Making operation functions to be called when needed
        {
            return num1 % num2;
        } //Percent Function/Method

    }
}
