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
    public class ALPsController : Controller
    {
        private FMGSuiteContext db = new FMGSuiteContext();

        // GET: ALPs
        public ActionResult Index()
        {
            return View(db.Compound.ToList());
        }

        // GET: ALPs/Details/5
        public ActionResult Details(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALP aLP = db.Compound.Find(id);
            if (aLP == null)
            {
                return HttpNotFound();
            }
            return View(aLP);
        }

        // GET: ALPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ALPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "alpDateTime,alpAvgHoldTime,alpAvgSpeedAnswer,alpMaxHoldTime,alpAbandoned,alpNumberOfAcceptedCalls,alpPercentAbandoned,alpAvgAbandonTime")] ALP aLP)
        {
            if (ModelState.IsValid)
            {
                db.Compound.Add(aLP);
                db.SaveChanges();
                return RedirectToAction("Create", "ENTs");
            }

            return View(aLP);
        }

        // GET: ALPs/Edit/5
        public ActionResult Edit(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALP aLP = db.Compound.Find(id);
            if (aLP == null)
            {
                return HttpNotFound();
            }
            return View(aLP);
        }

        // POST: ALPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "alpDateTime,alpAvgHoldTime,alpAvgSpeedAnswer,alpMaxHoldTime,alpAbandoned,alpNumberOfAcceptedCalls,alpPercentAbandoned,alpAvgAbandonTime")] ALP aLP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aLP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aLP);
        }

        // GET: ALPs/Delete/5
        public ActionResult Delete(DateTime id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALP aLP = db.Compound.Find(id);
            if (aLP == null)
            {
                return HttpNotFound();
            }
            return View(aLP);
        }

        // POST: ALPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(DateTime id)
        {
            ALP aLP = db.Compound.Find(id);
            db.Compound.Remove(aLP);
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
