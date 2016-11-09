using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAngularLearning.Controllers
{
    public class OrgRolesController : Controller
    {
        // GET: OrgRoles
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrgRoles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrgRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrgRoles/Create
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

        // GET: OrgRoles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrgRoles/Edit/5
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

        // GET: OrgRoles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrgRoles/Delete/5
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
