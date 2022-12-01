using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheTemptation.Controllers
{
    public class ResultatController : Controller
    {
        // GET: Resultat
        public ActionResult Resultat()
        {
            return View();
        }

        // GET: Resultat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resultat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resultat/Create
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

        // GET: Resultat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resultat/Edit/5
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

        // GET: Resultat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resultat/Delete/5
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
