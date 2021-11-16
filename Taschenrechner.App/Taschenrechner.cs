using System;
using System.Windows.Forms;
using Taschenrechner.Logic;

namespace Taschenrechner.App
{
    public partial class Taschenrechner : Form
    {
        public CalcLogic logic = new CalcLogic();

        public Taschenrechner()
        {
            InitializeComponent();

            logic.OnCalculationChanged += Logic_OnCalucationChanged;
        }

        private void Logic_OnCalucationChanged(object sender, string newResult)
        {
            this.textBox.Text = newResult;
        }

        public void oper_Click(object sender, EventArgs e)
        {
            string value = ((Button)sender).Text;

            try
            {
                logic.Oper(value);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("why don't you reinvent math??");
            }
        }

        public void clear_Click(object sender, EventArgs e)
        {
            logic.Clear();
        }

        public void equal_Click(object sender, EventArgs e)
        {
            try
            {
                logic.Calc();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("why don't you reinvent math??");
            }
        }
    }
}