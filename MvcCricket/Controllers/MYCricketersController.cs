using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCricket.Controllers
{
    public class MYCricketersController : Controller
    {
        // GET: MYCricketers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Önsel AYDIN";
            return View();
        }
    }
}