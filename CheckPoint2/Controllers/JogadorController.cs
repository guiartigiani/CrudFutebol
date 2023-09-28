using Checkpoint2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Checkpoint2.Controllers
{
    public class JogadorController : Controller
    {
        private static IList<Jogador> _ListaJog = new List<Jogador>();
        private static int _id = 0;
        
        public ActionResult Index()
        {
            return View(_ListaJog);
        }
        
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Jogador jogador)
        {
            try
            {
                jogador.Id = ++_id;
                _ListaJog.Add(jogador);
                TempData["mostrarMensagem"] = true;
                TempData["mensagem"] = "Jogador cadastrado com SUCESSO!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Edit(int id)
        {
            var jogador = _ListaJog.First(j => j.Id == id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Jogador jogador)
        {
            try
            {
                var index = _ListaJog.ToList().FindIndex(i => i.Id == jogador.Id);
                _ListaJog[index] = jogador;
                TempData["mostrarMensagem"] = true;
                TempData["mensagem"] = "Jogador atualizado com SUCESSO!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Jogador jogador)
        {
            try
            {
                _ListaJog.Remove(_ListaJog.First(j => j.Id == id));
                TempData["mostrarMensagem"] = true;
                TempData["mensagem"] = "Jogador removido com SUCESSO!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
