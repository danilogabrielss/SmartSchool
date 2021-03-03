using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Controllers
{
    public class LixoController : Controller
    {
        // GET: LixoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LixoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LixoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LixoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LixoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LixoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LixoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LixoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
