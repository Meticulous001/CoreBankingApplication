using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JUCBA.Core.Models;

namespace JUCBA.Controllers
{
    public class GlCategoriesControllers : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GlCategoriesControllers
        public async Task<ActionResult> Index()
        {
            return View(await db.GlCategories.ToListAsync());
        }

        // GET: GlCategoriesControllers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GlCategory glCategory = await db.GlCategories.FindAsync(id);
            if (glCategory == null)
            {
                return HttpNotFound();
            }
            return View(glCategory);
        }

        // GET: GlCategoriesControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GlCategoriesControllers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Description,MainCategory")] GlCategory glCategory)
        {
            if (ModelState.IsValid)
            {
                db.GlCategories.Add(glCategory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(glCategory);
        }

        // GET: GlCategoriesControllers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GlCategory glCategory = await db.GlCategories.FindAsync(id);
            if (glCategory == null)
            {
                return HttpNotFound();
            }
            return View(glCategory);
        }

        // POST: GlCategoriesControllers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Description,MainCategory")] GlCategory glCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(glCategory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(glCategory);
        }

        // GET: GlCategoriesControllers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GlCategory glCategory = await db.GlCategories.FindAsync(id);
            if (glCategory == null)
            {
                return HttpNotFound();
            }
            return View(glCategory);
        }

        // POST: GlCategoriesControllers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            GlCategory glCategory = await db.GlCategories.FindAsync(id);
            db.GlCategories.Remove(glCategory);
            await db.SaveChangesAsync();
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
