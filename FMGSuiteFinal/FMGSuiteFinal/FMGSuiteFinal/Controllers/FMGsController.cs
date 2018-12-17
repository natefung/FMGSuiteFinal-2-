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
    [Authorize]
    public class FMGsController : Controller
    {
        private FMGSuiteContext db = new FMGSuiteContext();

        public ActionResult Confirm()
        {
            return View();
        }

        // GET: FMGs
        public ActionResult Index()
        {
            return View(db.fmg.ToList());
        }

        // GET: FMGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMG fMG = db.fmg.Find(id);
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
        public ActionResult Create([Bind(Include = "fmgID,fmgAvgHoldTime,fmgAvgSpeedAnswer,fmgMaxHoldTime,fmgAbandoned,fmgNumberOfAcceptedCalls,fmgPercentAbandoned,fmgAvgAbandon,fmgDateTime")] FMG fMG)
        {
            if (ModelState.IsValid)
            {
                db.fmg.Add(fMG);
                db.SaveChanges();
                return RedirectToAction("Confirm");
            }

            return View(fMG);
        }

        // GET: FMGs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMG fMG = db.fmg.Find(id);
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
        public ActionResult Edit([Bind(Include = "fmgID,fmgAvgHoldTime,fmgAvgSpeedAnswer,fmgMaxHoldTime,fmgAbandoned,fmgNumberOfAcceptedCalls,fmgPercentAbandoned,fmgAvgAbandon,fmgDateTime")] FMG fMG)
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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FMG fMG = db.fmg.Find(id);
            if (fMG == null)
            {
                return HttpNotFound();
            }
            return View(fMG);
        }

        // POST: FMGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FMG fMG = db.fmg.Find(id);
            db.fmg.Remove(fMG);
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
