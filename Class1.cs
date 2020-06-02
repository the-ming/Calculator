using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public class Form1 : Form
    {
        //instance variables
        public Label input, line;
        public Button one, two, three, four, five, six, seven, eight, nine, zero,
                      plus, minus, multiply, divide, plusMinus, deciPoint, squared, 
                      sqrt, reciprocal, percent, clear, clearEntry, backspace, equals;
        public double[] numbers = new double[10];
        public string[] operations = new string[10];
        public int index = 0;
        

        //constructor for Form1
        public Form1()
        {
            //line
            line = new Label();
            line.Location = new Point(10, 10);
            line.Size = new Size(260, 15);
            line.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            line.BorderStyle = BorderStyle.FixedSingle;
            line.Text = "";

            //input
            input = new Label();
            input.Location = new Point(10, 30);
            input.Size = new Size(260, 50);
            input.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            input.BorderStyle = BorderStyle.FixedSingle;
            input.Font = new Font("Arial", 30);
            input.Text = "0";

            //plusMinus
            plusMinus = new Button();
            plusMinus.Location = new Point(5, 360);
            plusMinus.Size = new Size(64, 45);
            plusMinus.Text = "+/-";
            plusMinus.Click += new EventHandler(plusMinus_Click);

            //zero
            zero = new Button();
            zero.Location = new Point(74, 360);
            zero.Size = new Size(64, 45);
            zero.Text = "0";
            zero.Click += new EventHandler(zero_Click);

            //deciPoint
            deciPoint = new Button();
            deciPoint.Location = new Point(143, 360);
            deciPoint.Size = new Size(64, 45);
            deciPoint.Text = ".";
            deciPoint.Click += new EventHandler(deciPoint_Click);

            //equals
            equals = new Button();
            equals.Location = new Point(212, 360);
            equals.Size = new Size(64, 45);
            equals.Text = "=";
            equals.Click += new EventHandler(equals_Click);

            //one
            one = new Button();
            one.Location = new Point(5, 305);
            one.Size = new Size(64, 45);
            one.Text = "1";
            one.Click += new EventHandler(one_Click);

            //two
            two = new Button();
            two.Location = new Point(74, 305);
            two.Size = new Size(64, 45);
            two.Text = "2";
            two.Click += new EventHandler(two_Click);

            //three
            three = new Button();
            three.Location = new Point(143, 305);
            three.Size = new Size(64, 45);
            three.Text = "3";
            three.Click += new EventHandler(three_Click);

            //plus
            plus = new Button();
            plus.Location = new Point(212, 305);
            plus.Size = new Size(64, 45);
            plus.Text = "+";
            plus.Click += new EventHandler(plus_Click);

            //four
            four = new Button();
            four.Location = new Point(5, 250);
            four.Size = new Size(64, 45);
            four.Text = "4";
            four.Click += new EventHandler(four_Click);

            //five
            five = new Button();
            five.Location = new Point(74, 250);
            five.Size = new Size(64, 45);
            five.Text = "5";
            five.Click += new EventHandler(five_Click);

            //six
            six = new Button();
            six.Location = new Point(143, 250);
            six.Size = new Size(64, 45);
            six.Text = "6";
            six.Click += new EventHandler(six_Click);

            //minus
            minus = new Button();
            minus.Location = new Point(212, 250);
            minus.Size = new Size(64, 45);
            minus.Text = "-";
            minus.Click += new EventHandler(minus_Click);

            //seven
            seven = new Button();
            seven.Location = new Point(5, 195);
            seven.Size = new Size(64, 45);
            seven.Text = "7";
            seven.Click += new EventHandler(seven_Click);

            //eight
            eight = new Button();
            eight.Location = new Point(74, 195);
            eight.Size = new Size(64, 45);
            eight.Text = "8";
            eight.Click += new EventHandler(eight_Click);

            //nine
            nine = new Button();
            nine.Location = new Point(143, 195);
            nine.Size = new Size(64, 45);
            nine.Text = "9";
            nine.Click += new EventHandler(nine_Click);

            //multiply
            multiply = new Button();
            multiply.Location = new Point(212, 195);
            multiply.Size = new Size(64, 45);
            multiply.Text = "X";
            multiply.Click += new EventHandler(multiply_Click);

            //reciprocal
            reciprocal = new Button();
            reciprocal.Location = new Point(5, 140);
            reciprocal.Size = new Size(64, 45);
            reciprocal.Text = "1/x";
            reciprocal.Click += new EventHandler(reciprocal_Click);

            //squared
            squared = new Button();
            squared.Location = new Point(74, 140);
            squared.Size = new Size(64, 45);
            squared.Text = "x²";
            squared.Click += new EventHandler(squared_Click);

            //sqrt
            sqrt = new Button();
            sqrt.Location = new Point(143, 140);
            sqrt.Size = new Size(64, 45);
            sqrt.Text = "√x";
            sqrt.Click += new EventHandler(sqrt_Click);

            //divide
            divide = new Button();
            divide.Location = new Point(212, 140);
            divide.Size = new Size(64, 45);
            divide.Text = "÷";
            divide.Click += new EventHandler(divide_Click);

            //percent
            percent = new Button();
            percent.Location = new Point(5, 85);
            percent.Size = new Size(64, 45);
            percent.Text = "%";
            percent.Click += new EventHandler(percent_Click);

            //clearEntry
            clearEntry = new Button();
            clearEntry.Location = new Point(74, 85);
            clearEntry.Size = new Size(64, 45);
            clearEntry.Text = "CE";
            clearEntry.Click += new EventHandler(clearEntry_Click);

            //clear
            clear = new Button();
            clear.Location = new Point(143, 85);
            clear.Size = new Size(64, 45);
            clear.Text = "C";
            clear.Click += new EventHandler(clear_Click);

            //backspace
            backspace = new Button();
            backspace.Location = new Point(212, 85);
            backspace.Size = new Size(64, 45);
            backspace.Text = "⌫";
            backspace.Click += new EventHandler(backspace_Click);



            //the general form
            this.Text = "Calculator";
            this.Size = new Size(300, 450);
            this.Controls.Add(line);
            this.Controls.Add(input);
            this.Controls.Add(plusMinus);
            this.Controls.Add(zero);
            this.Controls.Add(deciPoint);
            this.Controls.Add(equals);
            this.Controls.Add(one);
            this.Controls.Add(two);
            this.Controls.Add(three);
            this.Controls.Add(plus);
            this.Controls.Add(four);
            this.Controls.Add(five);
            this.Controls.Add(six);
            this.Controls.Add(minus);
            this.Controls.Add(seven);
            this.Controls.Add(eight);
            this.Controls.Add(nine);
            this.Controls.Add(multiply);
            this.Controls.Add(reciprocal);
            this.Controls.Add(squared);
            this.Controls.Add(sqrt);
            this.Controls.Add(divide);
            this.Controls.Add(percent);
            this.Controls.Add(clearEntry);
            this.Controls.Add(clear);
            this.Controls.Add(backspace);
        }


        private void leadingZero()
        {
            if (input.Text.StartsWith("0") && input.Text.Length <= 2 && input.Text.Contains(".") == false)
                input.Text = input.Text.Substring(1);
            if (input.Text.Length == 0)
                input.Text = "0";
            
        }

        private void disableButtons()
        {
            reciprocal.Enabled = false;
            percent.Enabled = false;
            squared.Enabled = false;
            sqrt.Enabled = false;
            divide.Enabled = false;
            multiply.Enabled = false;
            minus.Enabled = false;
            plus.Enabled = false;
            plusMinus.Enabled = false;
            deciPoint.Enabled = false;
        }

        private void enableButtons()
        {
            reciprocal.Enabled = true;
            percent.Enabled = true;
            squared.Enabled = true;
            sqrt.Enabled = true;
            divide.Enabled = true;
            multiply.Enabled = true;
            minus.Enabled = true;
            plus.Enabled = true;
            plusMinus.Enabled = true;
            deciPoint.Enabled = true;
        }

        private void resetArrays()
        {
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = 0;
                operations[i] = null;
            }
            index = 0;
        }

        
        //numbers
        private void zero_Click(object sender, EventArgs e)
        {
            if(input.Text.Length <= 12 && input.Text.StartsWith("0") == false)
                input.Text += "0";
            leadingZero();
            enableButtons();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12)
                input.Text += "1";
            leadingZero();
            enableButtons();
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12)
                input.Text += "2";
            leadingZero();
            enableButtons();
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "3";
            leadingZero();
            enableButtons();
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "4";
            leadingZero();
            enableButtons();
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "5";
            leadingZero();
            enableButtons();
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "6";
            leadingZero();
            enableButtons();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "7";
            leadingZero();
            enableButtons();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "8";
            leadingZero();
            enableButtons();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (input.Text.Length <= 12) 
                input.Text += "9";
            leadingZero();
            enableButtons();
        }

        
        //basic operations
        private void plus_Click(object sender, EventArgs e)
        {
            line.Text += input.Text + " + ";
            numbers[index] = Convert.ToDouble(input.Text);
            operations[index] = "+";
            index += 1;
            input.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            line.Text += input.Text + " - ";
            numbers[index] = Convert.ToDouble(input.Text);
            operations[index] = "-";
            index += 1;
            input.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            line.Text += input.Text + " * ";
            numbers[index] = Convert.ToDouble(input.Text);
            operations[index] = "*";
            index += 1;
            input.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            line.Text += input.Text + " / ";
            numbers[index] = Convert.ToDouble(input.Text);
            operations[index] = "/";
            index += 1;
            input.Text = "";
        }


        //input changers
        private void plusMinus_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(input.Text);
            if (num != 0)
            {
                num = num * (-1);
                input.Text = num + "";
            }
        }

        private void deciPoint_Click(object sender, EventArgs e)
        {
            if (input.Text.Contains(".") == false)
                input.Text += ".";
        }
        
        private void clearEntry_Click(object sender, EventArgs e)
        {
            input.Text = "";
            enableButtons();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            line.Text = "";
            input.Text = "";
            for (int i = 0; i<10; i++)
            {
                numbers[i] = 0;
                operations[i] = null;
                enableButtons();
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            int minusone = input.Text.Length - 1;
            if (input.Text.Length == 1)
                input.Text = "0";
            else
                input.Text = input.Text.Substring(0, minusone);
            enableButtons();
        }



        private void reciprocal_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(input.Text);
            //can't use try catch statement because doubles will output infinity instead of 
            /*try
            {
                line.Text += "1/(" + num + ")";
                num = 1 / num;
                input.Text = num + "";
            }
            catch (DivideByZeroException exception)
            {
                input.Text = "Cannot divide by 0";
            }*/
            double reciprocal = 1 / num;
            if (Double.IsInfinity(reciprocal))
            {
                disableButtons();
                input.Text = "Cannot divide by 0";
                //reset arrays
                resetArrays();
            }
            else
                input.Text = reciprocal + "";

        }

        private void squared_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(input.Text);
            double square = Math.Pow(num, 2);
            input.Text = square + "";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(input.Text);
            double root = Math.Sqrt(num);
            if (double.IsNaN(root))
            {
                disableButtons();
                input.Text = "Invalid input: cannot sqrt a negative number";
                //reset arrays
                resetArrays();
            }
            else
                input.Text = root + "";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            //percent takes the input and finds that percent of the number before : https://devblogs.microsoft.com/oldnewthing/20080110-00/?p=23853
            double inputPercent = Convert.ToDouble(input.Text);
            //converts number to percent
            double percent = inputPercent / 100;
            double newnum = numbers[index - 1] * percent;
            input.Text = newnum + "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            //sets last entry to array
            double num = Convert.ToDouble(input.Text);
            numbers[index] = num;
            line.Text += num + "";

            //new arrays set to length of inputs
            //number array
            double[] finalnum = new double[index + 1];
            index = 0;
            foreach (double item in numbers)
            {
                if (item == 0)
                    break;
                else
                    finalnum[index] = item;
                index++;
            }
            //operation array
            
            string[] finaloperation = new string[index];
            index = 0;
            foreach (string item in operations)
            {
                if (item == null)
                    break;
                else
                    finaloperation[index] = item;
                index++;
            }


            //variables that are set to the numbers from the foreach loop
            double result = finalnum[0];
            double nextvalue = 0;
            int operationindex = 0;
            for (int i = 0; i < finalnum.Length-1; i++)
            {
                nextvalue = finalnum[i + 1];
                if (finaloperation[operationindex] == "+")
                {
                    result += nextvalue;
                }
                if (finaloperation[operationindex] == "-")
                {
                    result -= nextvalue;
                }
                if (finaloperation[operationindex] == "*")
                {
                    result *= nextvalue;
                }
                if (finaloperation[operationindex] == "/")
                {
                    result /= nextvalue;
                }
                operationindex++;
            }
            enableButtons();
            input.Text = result + "";
            resetArrays();
            line.Text = "";
        }


        //main method
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
