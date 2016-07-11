using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using arihant.DAL;
using arihant.Models;

namespace arihant.Controllers
{
    public class mailController : Controller
    {
        private arihantcontext db = new arihantcontext();

        // GET: mail
        public ActionResult Index()
        {
            return View(db.mails.ToList());
        }

        // GET: mail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mail mail = db.mails.Find(id);
            if (mail == null)
            {
                return HttpNotFound();
            }
            return View(mail);
        }

        // GET: mail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,sentemailid,recemailid,senttime,rectime")] mail mail)
        {
            if (ModelState.IsValid)
            {
                db.mails.Add(mail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mail);
        }

        // GET: mail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mail mail = db.mails.Find(id);
            if (mail == null)
            {
                return HttpNotFound();
            }
            return View(mail);
        }

        // POST: mail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,sentemailid,recemailid,senttime,rectime")] mail mail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mail);
        }

        // GET: mail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mail mail = db.mails.Find(id);
            if (mail == null)
            {
                return HttpNotFound();
            }
            return View(mail);
        }

        // POST: mail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mail mail = db.mails.Find(id);
            db.mails.Remove(mail);
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
