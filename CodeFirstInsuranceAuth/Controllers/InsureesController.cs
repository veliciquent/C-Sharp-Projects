using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstInsuranceAuth.Context;
using CodeFirstInsuranceAuth.Models;
using Microsoft.AspNet.Identity;

namespace CodeFirstInsuranceAuth.Controllers
{
    public class InsureesController : Controller
    {
        private InsureeContext db = new InsureeContext();

        // GET: Insurees
        public ActionResult Index()
        {
            return View(db.Insuree.ToList());
        }

        // GET: Insurees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insuree.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insurees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Username,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal Quote = 50;
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (age <= 18)
                {
                    Quote += 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    Quote += 50;
                }
                else if (age > 25)
                {
                    Quote += 25;
                }

                if (insuree.CarYear <= 2000)
                {
                    Quote += 25;
                }
                else if (insuree.CarYear >= 2015)
                {
                    Quote += 25;
                }
                if (insuree.CarMake == "Porsche")
                {
                    if (insuree.CarModel == "911 Carrera")
                    {
                        Quote += 25;
                    }
                    Quote += 25;
                }
                Quote += (insuree.SpeedingTickets * 10);
                if (insuree.DUI == true)
                {
                    Quote += (Quote / 4);
                }
                if (insuree.CoverageType == true)
                {
                    Quote += (Quote / 2);
                }
                insuree.Username = User.Identity.GetUserName();
                insuree.Quote = Quote;
                db.Insuree.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insuree.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Username,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insuree.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insuree.Find(id);
            db.Insuree.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
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
