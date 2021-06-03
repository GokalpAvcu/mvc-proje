using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        MessageManager cm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            return View();
        }
    }
}