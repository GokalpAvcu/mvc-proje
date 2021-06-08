using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        [HttpGet]
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {

            var contact = cm.GetList().Count();
            ViewBag.contact = contact;

            var SendMail = mm.GetListSendbox().Count();
            ViewBag.SendMail = SendMail;

            var ReceiverMail = mm.GetListInbox().Count();
            ViewBag.receiverMail = ReceiverMail;

            var DraftMail = mm.GetListSendbox().Where(m => m.IsDraft == true).Count();
            ViewBag.DraftMail = DraftMail;

            return PartialView();


        }
    }
}
