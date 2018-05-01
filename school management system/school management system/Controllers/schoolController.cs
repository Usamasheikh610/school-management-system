using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace school_management_system.Controllers
{
    public class schoolController : Controller
    {
        // GET: school
        public ActionResult Index()
        {
            return View();
        }

        // GET: school/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: school/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: school/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: school/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: school/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: school/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: school/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
