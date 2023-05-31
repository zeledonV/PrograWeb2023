using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Models
{
    public class CategoryModels : Controller
    {
        // GET: CategoryModels
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryModels/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryModels/Create
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

        // GET: CategoryModels/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryModels/Edit/5
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

        // GET: CategoryModels/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryModels/Delete/5
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
