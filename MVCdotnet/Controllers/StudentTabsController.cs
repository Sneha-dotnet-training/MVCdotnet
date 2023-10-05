using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCdotnet.Models;
using MVCdotnet.Filters;

namespace MVCdotnet.Controllers
{
    [RoutePrefix("Student")]
    
    public class StudentTabsController : Controller
    {
        private snbEntities db = new snbEntities();

        // GET: StudentTabs
        [Route("get")]
        public ActionResult Index()
        {
            return View(db.StudentTabs.ToList());
        }

        // GET: StudentTabs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTab studentTab = db.StudentTabs.Find(id);
            if (studentTab == null)
            {
                return HttpNotFound();
            }
            return View(studentTab);
        }

        // GET: StudentTabs/Create
        [Route("write")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentTabs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("write")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,FirstName,LastName")] StudentTab studentTab)
        {
            if (ModelState.IsValid)
            {
                db.StudentTabs.Add(studentTab);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentTab);
        }

        // GET: StudentTabs/Edit/5
        [Route("Edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTab studentTab = db.StudentTabs.Find(id);
            if (studentTab == null)
            {
                return HttpNotFound();
            }
            return View(studentTab);
        }

        // POST: StudentTabs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName")] StudentTab studentTab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentTab).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentTab);
        }

        // GET: StudentTabs/Delete/5
        [Route("Remove")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTab studentTab = db.StudentTabs.Find(id);
            if (studentTab == null)
            {
                return HttpNotFound();
            }
            return View(studentTab);
        }
        [Route("Remove")]
        // POST: StudentTabs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentTab studentTab = db.StudentTabs.Find(id);
            db.StudentTabs.Remove(studentTab);
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
