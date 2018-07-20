using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyMaking.Controllers
{
    public class HowItWorksController : Controller
    {
        // GET: HowItWorks
        public ActionResult Outbound()
        {
            return View();
        }
        public ActionResult Inbound()
        {
            return View();
        }
        public ActionResult VirtualAssistants()
        {
            return View();
        }
    }
}