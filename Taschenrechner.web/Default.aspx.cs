using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Taschenrechner.Logic;

namespace Taschenrechner.web
{
    public partial class Default : System.Web.UI.Page
    {
        public CalcLogic logic = new CalcLogic();

        public Default()
        {
            logic.OnCalculationChanged += Logic_OnCalucationChanged;
        }

        private void Logic_OnCalucationChanged(object sender, string newResult)
        {
            this.TextBox1.Text = newResult;
        }


        protected void oper_Click(object sender, EventArgs e)
        {
            string value = ((Button)sender).Text;

            try
            {
                logic.Oper(value);
            }
            catch (DivideByZeroException)
            {
                //MessageBox.Show("why don't you reinvent math??");
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            logic.Clear();
        }

        protected void equal_Click(object sender, EventArgs e)
        {
            try
            {
                logic.Calc();
            }
            catch (DivideByZeroException)
            {
                //MessageBox.Show("why don't you reinvent math??");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}