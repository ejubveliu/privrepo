using System;
using System.Collections.Generic;

namespace Taschenrechner.App
{
    public class CalcLogic
    {
        /*public void Equals(string op, double result, double number1, double number2, List<string> calc)
        {
        }
        */

        public void Oper(bool isopclicked, string opervar, double number1, double number2, List<string> calc, double result, string op)
        {
            if (isopclicked)
            {
                number1 = Double.Parse(calc[0]);
                number2 = Double.Parse(calc[1]);

                switch (op)
                {
                    case "+":
                        calc = Addieren(calc);
                        break;

                    case "-":
                        calc = Subtrahieren(calc);
                        break;

                    case "*":
                        calc = Multiplizieren(calc);
                        break;

                    case "/":
                        if (number1 == 0)
                        {
                            //Taschenrechner.App.Form1.msgBox1();
                        }
                        else if (number2 == 0)
                        {
                            //Taschenrechner.App.Form1.msgBox2();
                        }
                        else
                        {
                            calc = Dividieren(calc);
                        }

                        break;

                    default:
                        break;
                }

                isopclicked = false;
                result = Double.Parse(calc[0]);
            }

            isopclicked = true;
        }

        public void Zero(List<string> calc, double number1, string num0)
        {
            calc[0] += String.Join(number1.ToString(), num0);
        }

        public void One(List<string> calc, string num0)
        {
            calc[1] += String.Join(calc[0], num0);
        }

        public void Clear(bool isopclicked, List<string> calc, string op, double result, double number1, double number2)
        {
            isopclicked = false;
            calc[0] = string.Empty;
            calc[1] = string.Empty;
            op = string.Empty;
            result = 0.0;
            number1 = 0.0;
            number2 = 0.0;
        }
        
        public void Dot(bool isopclicked, List<string> calc, double number1, string dot)
        {
            if (isopclicked)
            {
                calc[1] += String.Join(calc[0], dot);
            }
            else
            {
                calc[0] += String.Join(number1.ToString(), dot);
            }
        }

        public List<string> Addieren(List<string> calc)
        {
            double result = Double.Parse(calc[0]) + Double.Parse(calc[1]);
            calc[0] = result.ToString();
            calc[1] = string.Empty;
            return calc;
        }

        public List<string> Subtrahieren(List<string> calc)
        {
            double result = Double.Parse(calc[0]) - Double.Parse(calc[1]);
            calc[0] = result.ToString();
            calc[1] = string.Empty;
            return calc;
        }

        public List<string> Dividieren(List<string> calc)
        {
            double result = Double.Parse(calc[0]) / Double.Parse(calc[1]);
            calc[0] = result.ToString();
            calc[1] = string.Empty;
            return calc;
        }

        public List<string> Multiplizieren(List<string> calc)
        {
            double result = Double.Parse(calc[0]) * Double.Parse(calc[1]);
            calc[0] = result.ToString();
            calc[1] = string.Empty;
            return calc;
        }
    }
}