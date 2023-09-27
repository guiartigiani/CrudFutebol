using Checkpoint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint2.Controllers
{
    public class CampeonatoController : Controller
    {
        private static IList<Campeonato> _ListaCamp = new List<Campeonato>();
        private static int _id = 0;
        
        public ActionResult Index()
        {
            return View(_ListaCamp);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Campeonato camp)
        {
            try
            {
                camp.Id = ++_id;
                _ListaCamp.Add(camp);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var camp = _ListaCamp.First(c => c.Id == id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Campeonato camp)
        {
            try
            {
                var index = _ListaCamp.ToList().FindIndex(c => c.Id == camp.Id);
                _ListaCamp[index] = camp;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Campeonato camp)
        {
            try
            {
                _ListaCamp.Remove(_ListaCamp.First(c => c.Id == id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
