using System;
using System.Web.UI.WebControls;
using Taschenrechner.Logic;

namespace Taschenrechner.web
{
    public partial class Default : System.Web.UI.Page
    {
        public CalcLogic logic;

        private const string SESSIONLOGIC = "session.logic";

        public Default()
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            Restore();
            logic.OnCalculationChanged += Logic_OnCalucationChanged;
            base.OnLoad(e);

            this.Hidemsg();
        }

        protected override void OnUnload(EventArgs e)
        {
            Backup();
            base.OnUnload(e);
        }

        public void Restore()
        {
            if(Session[SESSIONLOGIC]==null)
            {
                Session[SESSIONLOGIC] = new CalcLogic();
            }

            this.logic = Session[SESSIONLOGIC] as CalcLogic;
        }

        public void Backup()
        {
            Session[SESSIONLOGIC] = this.logic;
        }

        private void Logic_OnCalucationChanged(object sender, string newResult)
        {
            this.TxtBox.Text = newResult;
        }

        protected void Oper_Click(object sender, EventArgs e)  
        {
            string value = ((Button)sender).Text;

            try
            {
                logic.Oper(value);
            }
            catch (DivideByZeroException)
            {
                this.Showmsg("cannot divide by 0");
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            logic.Clear();
        }

        protected void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                logic.Calc();
            }
            catch (DivideByZeroException)
            {
                this.Showmsg("cannot divide by 0");
            }
        }

        private void Showmsg(string msg)
        {
            this.errormsgtxt.Text = msg;
            errormsg.Visible = true;
        }

        private void Hidemsg()
        {
            this.errormsg.Visible = false;
        }
    }
}