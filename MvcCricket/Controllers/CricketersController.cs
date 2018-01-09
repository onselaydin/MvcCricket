using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MvcCricket.Models;

namespace MvcCricket.Controllers
{
    public class CricketersController : Controller
    {
        private Cricketers db = new Cricketers();

        // GET: Cricketers
        public ActionResult Index()
        {
            return View(db.Cricketer.ToList());
        }

        // GET: Cricketers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketer.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // GET: Cricketers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cricketers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,ODI,Test")] Cricketer cricketer)
        {
            if (ModelState.IsValid)
            {
                db.Cricketer.Add(cricketer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cricketer);
        }

        // GET: Cricketers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketer.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // POST: Cricketers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,ODI,Test")] Cricketer cricketer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cricketer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cricketer);
        }

        // GET: Cricketers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketer.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // POST: Cricketers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cricketer cricketer = db.Cricketer.Find(id);
            db.Cricketer.Remove(cricketer);
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
