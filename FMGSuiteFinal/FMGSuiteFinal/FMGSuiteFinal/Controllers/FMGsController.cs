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
    public class FMGsController : Controller
    {
        private FMGSuiteContext db = new FMGSuiteContext();

        // GET: FMGs
        public ActionResult Index()
        {
            return View(db.Assay.ToList());
        }

        // GET: FMGs/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMG fMG = db.Assay.Find(id);
            if (fMG == null)
            {
                return HttpNotFound();
            }
            return View(fMG);
        }

        // GET: FMGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FMGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fmgDateTime,fmgAvgHoldTime,fmgAvgSpeedAnswer,fmgMaxHoldTime,fmgAbandoned,fmgNumberOfAcceptedCalls,fmgPercentAbandoned,fmgAvgAbandonTime")] FMG fMG)
        {
            if (ModelState.IsValid)
            {
                db.Assay.Add(fMG);
                db.SaveChanges();
                return RedirectToAction("Index", "FMGs");
            }

            return View(fMG);
        }

        // GET: FMGs/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMG fMG = db.Assay.Find(id);
            if (fMG == null)
            {
                return HttpNotFound();
            }
            return View(fMG);
        }

        // POST: FMGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fmgDateTime,fmgAvgHoldTime,fmgAvgSpeedAnswer,fmgMaxHoldTime,fmgAbandoned,fmgNumberOfAcceptedCalls,fmgPercentAbandoned,fmgAvgAbandonTime")] FMG fMG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fMG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fMG);
        }

        // GET: FMGs/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMG fMG = db.Assay.Find(id);
            if (fMG == null)
            {
                return HttpNotFound();
            }
            return View(fMG);
        }

        // POST: FMGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            FMG fMG = db.Assay.Find(id);
            db.Assay.Remove(fMG);
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
