using System;
using System.Collections.Generic;

namespace Taschenrechner.App
{
    public class CalcLogic
    {
        private List<string> values = new List<string> { "", "" };
        public double result = 0.0;
        public string operation;

        public event CalculationChangedHandler OnCalculationChanged;

        public delegate void CalculationChangedHandler(object sender, string newResult);

        public void Clear()//DONE
        {
            values[0] = string.Empty;
            values[1] = string.Empty;
            operation = string.Empty;
            result = 0.0;
        }

        public void Oper(string value)
        {
            if (value == "+" || value == "-" || value == "*" || value == "/")
                HandleOperation(value);
            else
                HandleZahlen(value);
        }//DONE

        private void HandleOperation(string value)
        {
            if (!string.IsNullOrEmpty(values[0]) && !string.IsNullOrEmpty(values[1]))
            {
                switch (value)
                {
                    case "+":
                        operation = "+";
                        Addieren();
                        break;

                    case "-":
                        operation = "-";
                        Subtrahieren();
                        break;

                    case "*":
                        operation = "*";
                        Multiplizieren();
                        break;

                    case "/":
                        operation = "/";
                        Dividieren();
                        break;

                    default:
                        break;
                }

                if (OnCalculationChanged != null)
                    OnCalculationChanged(this, result.ToString());
            }
            else if (!string.IsNullOrEmpty(values[0]))
            {
                switch (value)
                {
                    case "+":
                        operation = "+";
                        break;

                    case "-":
                        operation = "-";
                        break;

                    case "*":
                        operation = "*";
                        break;

                    case "/":
                        operation = "/";
                        break;

                    default:
                        break;

                }

                if (OnCalculationChanged != null)
                    OnCalculationChanged(this, values[0].ToString());
            }
        }//DONE

        private void HandleZahlen(string value)
        {
            if (value == ".")
            {
                if (!values[0].Contains("."))
                    values[0] = String.Join(values[0], value);
                else
                    values[1] = String.Join(values[1], value);
            }
            else
            {
                if (string.IsNullOrEmpty(operation))
                    values[0] += String.Join(values[0], value);
                else
                    values[1] += String.Join(values[1], value);
            }
        }//DONE

        public void Calc()
        {
            switch (operation)
            {
                case "+":
                    values = Addieren();
                    break;

                case "-":
                    values = Subtrahieren();
                    break;

                case "*":
                    values = Multiplizieren();
                    break;

                case "/":
                    values = Dividieren();
                    break;

                default:
                    break;
            }

            if (OnCalculationChanged != null)
                OnCalculationChanged(this, result.ToString());
        }

        private List<string> Addieren()
        {
            result = Double.Parse(values[0]) + Double.Parse(values[1]);
            values[0] = result.ToString();
            values[1] = string.Empty;
            return values;
        }//DONE

        private List<string> Subtrahieren()
        {
            result = Double.Parse(values[0]) - Double.Parse(values[1]);
            values[0] = result.ToString();
            values[1] = string.Empty;
            return values;
        }//DONE

        private List<string> Multiplizieren()
        {
            result = Double.Parse(values[0]) * Double.Parse(values[1]);
            values[0] = result.ToString();
            values[1] = string.Empty;
            return values;
        }//DONE

        private List<string> Dividieren()
        {
            if (values[0] == "0")
                throw new DivideByZeroException();
            else if (values[1] == "0")
                throw new DivideByZeroException();
            else
            {
                result = Double.Parse(values[0]) / Double.Parse(values[1]);
                values[0] = result.ToString();
                values[1] = string.Empty;
            }
            return values;
        }//DONE
    }
}