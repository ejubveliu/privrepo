using System;
using System.Web;
using System.Web.Http;
using Taschenrechner.Logic;

namespace Taschenrechner.webapi
{
    public class CalcController : ApiController
    {
        private const string SESSIONLOGIC = "session.logic";
        private string result = string.Empty;

        public CalcLogic logic;

        public CalcController()
        {
            Restore();
            logic.OnCalculationChanged += Logic_OnCalculationChanged;
        }

        private void Logic_OnCalculationChanged(object sender, string newResult)
        {
            result = newResult;
        }

        ~CalcController()
        {
            Backup();
        }

        public void Restore()
        {
            if (HttpContext.Current.Session[SESSIONLOGIC] == null)
            {
                HttpContext.Current.Session[SESSIONLOGIC] = new CalcLogic();
            }

            this.logic = HttpContext.Current.Session[SESSIONLOGIC] as CalcLogic;
        }

        public void Backup()
        {
            HttpContext.Current.Session[SESSIONLOGIC] = this.logic;
        }

        [HttpGet]
        [ActionName("GetClear")]
        public string Clearstring()
        {
            logic.Clear();
            return this.result;
        }

        [HttpGet]
        [ActionName("GetOper")]
        public string Operstring(string value)
        {
            try
            {
                logic.Oper(value);
            }
            catch (DivideByZeroException)
            {
                //this.Showmsg("cannot divide by 0");
            }

            return this.result;
        }

        [HttpGet]
        [ActionName("GetEqual")]
        public string Equalstring()
        {
            try
            {
                logic.Calc();
            }
            catch (DivideByZeroException)
            {
                //this.Showmsg("cannot divide by 0");
            }

            return this.result;
        }
    }
}