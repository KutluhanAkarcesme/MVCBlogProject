using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace UI.Web.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        private ContactManager contactManager = new ContactManager(new EFContactDal());
        ContactValidator contactValidator = new ContactValidator();

        public ActionResult Index()
        {
            List<Contact> contactValues = contactManager.GetList();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.GetById(id);
            return View(contactValues);
        }
    }
}