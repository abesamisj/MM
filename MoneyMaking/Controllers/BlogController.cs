using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneyMaking.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        // GET: Blog
        public ActionResult Article1()
        {
            return View();
        }

        // GET: Blog
        public ActionResult Article2()
        {
            return View();
        }
    }
}