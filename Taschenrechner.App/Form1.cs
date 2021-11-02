using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taschenrechner.App
{
    public partial class Form1 : Form
    {
        private List<string> calc = new List<string>() { "",""};
        public string op;
        public double var = 0.0;
        public double result = 0.0;
        public double number1 = 0.0;
        public double number2 = 0.0;
        public bool isopclicked = false;
        public CalcLogic logic = new CalcLogic();

        public Form1()
        {
            InitializeComponent();
        }

        public void zero_Click(object sender, EventArgs e)
        {
            string num0 = ((Button)sender).Text;
            textBox.Text += ((Button)sender).Text;

            if (isopclicked)
            {
                logic.One(calc, num0);
            }
            else
            {
                logic.Zero(calc, number1, num0);
            }
        }

        public void oper_Click(object sender, EventArgs e)
        {
            string opervar = ((Button)sender).Text;
            logic.Oper(isopclicked, opervar, number1, number2, calc, result, op);

            if (isopclicked)
            {
                equal_Click(sender, e);
            }

            isopclicked = true;
            op = opervar;
            textBox.Text += op;
        }

        public void clear_Click(object sender, EventArgs e)
        {
            logic.Clear(isopclicked, calc, op, result, number1, number2);
            textBox.Text = string.Empty;
        }

        public void dot_Click(object sender, EventArgs e)
        {
            textBox.Text += ((Button)sender).Text;
            string dot = ((Button)sender).Text;
            logic.Dot(isopclicked, calc, number1, dot);
        }

        
        public void equal_Click(object sender, EventArgs e)
        {
            //logic.Equals();
            number1 = Double.Parse(calc[0]);
            number2 = Double.Parse(calc[1]);

            switch (op)
            {
                case "+":
                    calc = logic.Addieren(calc);
                    break;

                case "-":
                    calc = logic.Subtrahieren(calc);
                    break;

                case "*":
                    calc = logic.Multiplizieren(calc);
                    break;

                case "/":
                    if (number1 == 0)
                    {
                        MessageBox.Show("you thought why not reinvent math");
                    }
                    else if (number2 == 0)
                    {
                        MessageBox.Show("you thought why not reinvent math");
                    }
                    else
                    {
                        calc = logic.Dividieren(calc);
                    }

                    break;

                default:
                    break;
            }

            isopclicked = false;
            textBox.Text = calc[0];
        }


        /*public void msgBox1()
        {

        }
        public void msgBox2()
        {

        }
        */
    }
}