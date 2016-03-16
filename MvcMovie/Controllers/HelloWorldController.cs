using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "This is my <b>Default</b> aciont";
        }

        public string Welcome(string name ,int ID = 3)
        {
            return HttpUtility.HtmlEncode("Hello "+name+" Numtimes is "+ID);
        }
    }
}