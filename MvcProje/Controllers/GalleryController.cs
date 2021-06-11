using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        ImageFileManager ifm = new ImageFileManager(new EfImageFildeDal());

        public ActionResult Index()
        {
            return View();
        }
    }
}