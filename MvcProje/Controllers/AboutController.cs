using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            return View();
        }
    }
}