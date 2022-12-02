using DataLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TheTemptation.Controllers
{
    public class JeuController : Controller
    {
        // GET: JeuController
        public ActionResult Jeu()
        {
            return View();
        }

        // GET: JeuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JeuController/Create
        public IActionResult Create()
        {
            var drawT = new Draw();
            return View(drawT);
        }

        //Test Recup Nb
        public IActionResult CreateDraw(Draw draw)
        {
            return View("Jeu");
        }

        // POST: JeuController/Create
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

        // GET: JeuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JeuController/Edit/5
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

        // GET: JeuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JeuController/Delete/5
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
