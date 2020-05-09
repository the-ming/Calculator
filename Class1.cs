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
        public Button one, two, three, four, five, six, seven, eight, nine, zero, plus, minus, multiply, divide, plusMinus, deciPoint, backspace, equals;

        
        //constructor for Form1
        public Form1()
        {
            


            //line
            line = new Label();
            line.Location = new Point(10, 10);
            line.Size = new Size(260, 15);
            line.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            line.BorderStyle = BorderStyle.FixedSingle;

            //input
            input = new Label();
            input.Location = new Point(10, 30);
            input.Size = new Size(260, 50);
            input.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            input.BorderStyle = BorderStyle.FixedSingle;

            /*
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
            */

            //the general form
            this.Text = "Calculator";
            this.Size = new Size(300, 500);
            this.Controls.Add(line);
            this.Controls.Add(input);
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
