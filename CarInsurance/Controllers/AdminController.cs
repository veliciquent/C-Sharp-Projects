using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities2 db = new InsuranceEntities2();
        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
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