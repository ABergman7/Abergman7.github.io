﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework7.DAL;
using Homework7.Models;

namespace Homework7.Controllers
{
    public class RequestsController : Controller
    {
        private RequestContext db = new RequestContext();

        // GET: Requests
        public ActionResult Index()
        {
            return View();
        }

  

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
