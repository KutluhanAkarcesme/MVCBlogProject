﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Web.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentByHeading()
        {
            return View();
        }
    }
}