using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FMGSuiteFinal.DAL;
using FMGSuiteFinal.Models;

namespace FMGSuiteFinal.Controllers
{
    public class ENTsController : Controller
    {
        private FMGSuiteContext db = new FMGSuiteContext();

        // GET: ENTs
        public ActionResult Index()
        {
            return View(db.Balance.ToList());
        }

        // GET: ENTs/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENT eNT = db.Balance.Find(id);
            if (eNT == null)
            {
                return HttpNotFound();
            }
            return View(eNT);
        }

        // GET: ENTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ENTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "entDateTime,entAvgHoldTime,entAvgSpeedAnswer,entMaxHoldTime,entAbandoned,entNumberOfAcceptedCalls,entPercentAbandoned,entAvgAbandonTime")] ENT eNT)
        {
            if (ModelState.IsValid)
            {
                db.Balance.Add(eNT);
                db.SaveChanges();
                return RedirectToAction("Create", "FMGs");
            }

            return View(eNT);
        }

        // GET: ENTs/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENT eNT = db.Balance.Find(id);
            if (eNT == null)
            {
                return HttpNotFound();
            }
            return View(eNT);
        }

        // POST: ENTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "entDateTime,entAvgHoldTime,entAvgSpeedAnswer,entMaxHoldTime,entAbandoned,entNumberOfAcceptedCalls,entPercentAbandoned,entAvgAbandonTime")] ENT eNT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eNT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eNT);
        }

        // GET: ENTs/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ENT eNT = db.Balance.Find(id);
            if (eNT == null)
            {
                return HttpNotFound();
            }
            return View(eNT);
        }

        // POST: ENTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            ENT eNT = db.Balance.Find(id);
            db.Balance.Remove(eNT);
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
