using Checkpoint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint2.Controllers
{
    public class TimeController : Controller
    {
        private static IList<Time> _ListaTimes = new List<Time>();
        private static int _id = 0;

        public ActionResult Index()
        {
            return View(_ListaTimes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Time time)
        {
            try
            {
                time.Id = ++_id;
                _ListaTimes.Add(time);
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
            var time = _ListaTimes.First(t => t.Id == id);
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Time time)
        {
            try
            {
                var index = _ListaTimes.ToList().FindIndex(t => t.Id == time.Id);
                _ListaTimes[index] = time;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _ListaTimes.Remove(_ListaTimes.First(t => t.Id == id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
