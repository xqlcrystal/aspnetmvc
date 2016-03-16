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
        public ActionResult Index()
        {
            return  View();
        }

        public string Welcome(string name ,int ID = 3)
        {
            return HttpUtility.HtmlEncode("Hello "+name+" Numtimes is "+ID);
        }
    }
}