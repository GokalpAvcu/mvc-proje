using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult Index()
        {
            return View();
        }
    }
}