using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Taschenrechner.webapi
{
    public class HelloWorldController : ApiController
    {
        // GET api/<controller>/5
        [HttpGet]
        [ActionName("GetHelloWorld")]
        public string HelloWorld()
        {
            return "Hello World";
        }

    }
}