using System;
using System.Collections.Generic;

namespace Taschenrechner.Logic
{
    public class CalcLogic
    {
        private List<string> values = new List<string> { "", "" };
        public double result = 0.0;
        public string operation = string.Empty;

        public event CalculationChangedHandler OnCalculationChanged;

        public delegate void CalculationChangedHandler(object sender, string newResult);

        public void Clear()
        {
            values[0] = string.Empty;
            values[1] = string.Empty;
            operation = string.Empty;
            result = 0.0;

            // Clear UI
            UpdateUI(string.Empty);
        }

        public void Oper(string value)
        {
            if (value == "+" || value == "-" || value == "*" || value == "/")
                HandleOperation(value);
            else
                HandleZahlen(value);
        }

        private void HandleOperation(string value)
        {
            if (!string.IsNullOrEmpty(values[0]))
            {
                switch (value)
                {
                    case "+":
                        operation = "+";

                        if (!string.IsNullOrEmpty(values[1]))
                            Addieren();

                        break;

                    case "-":
                        operation = "-";

                        if (!string.IsNullOrEmpty(values[1]))
                            Subtrahieren();

                        break;

                    case "*":
                        operation = "*";

                        if (!string.IsNullOrEmpty(values[1]))
                            Multiplizieren();

                        break;

                    case "/":
                        operation = "/";

                        if (!string.IsNullOrEmpty(values[1]))
                            Dividieren();

                        break;

                    default:
                        break;
                }

                UpdateUI(!string.IsNullOrEmpty(values[1]) ? result.ToString() : GetMathString());
            }
        }

        private void HandleZahlen(string value)
        {
            if (value == ".")
            {
                if (!values[0].Contains(".") && operation == string.Empty)
                    values[0] += String.Join(values[0], value);
                else if (operation != string.Empty && !values[1].Contains("."))
                    values[1] += String.Join(values[1], value);
            }
            else
            {
                if (string.IsNullOrEmpty(operation))
                    values[0] += String.Join(values[0], value);
                else
                    values[1] += String.Join(values[1], value);
            }

            UpdateUI(GetMathString());
        }

        public void Calc()
        {
            switch (operation)
            {
                case "+":
                    Addieren();
                    break;

                case "-":
                    Subtrahieren();
                    break;

                case "*":
                    Multiplizieren();
                    break;

                case "/":
                    Dividieren();
                    break;

                default:
                    break;
            }
            operation = string.Empty;

            UpdateUI(result.ToString());
        }

        private void Addieren()
        {
            result = Double.Parse(values[0]) + Double.Parse(values[1]);
            values[0] = result.ToString();
            values[1] = string.Empty;
        }

        private void Subtrahieren()
        {
            result = Double.Parse(values[0]) - Double.Parse(values[1]);
            values[0] = result.ToString();
            values[1] = string.Empty;
        }

        private void Multiplizieren()
        {
            result = Double.Parse(values[0]) * Double.Parse(values[1]);
            values[0] = result.ToString();
            values[1] = string.Empty;
        }

        private void Dividieren()
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
        }

        private void UpdateUI(string text)
        {
            if (OnCalculationChanged != null)
                OnCalculationChanged(this, text);
        }

        private string GetMathString()
        {
            return $"{values[0]}{operation}{values[1]}";
        }
    }
}