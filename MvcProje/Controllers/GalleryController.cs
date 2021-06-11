using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager hm = new ImageFileManager(new EfHeadingDal());

        public ActionResult Index()
        {
            return View();
        }
    }
}