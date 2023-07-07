using System.Reflection;
using CalculadoraOnlineDePiso.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraOnlineDePiso.Controllers
{
    public class PisoController : Controller
    {
        private static List<Piso> pisos = new List<Piso>(); // Lista para armazenar os produtos

        public ActionResult Index()
        {
            return View(pisos); // Retorna a lista de produtos para a view Index
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Piso piso)
        {
            if (ModelState.IsValid)
            {
                piso.CalculoArea = (piso.Area1 * piso.Area2);
                piso.CalculoPiso = piso.CalculoArea/(piso.Piso1 * piso.Piso2);

                piso.Id = pisos.Count + 1;
                pisos.Add(piso);
                return RedirectToAction("Index");
            }
            return View(piso);
        }

        public ActionResult Edit(int id)
        {
            var produto = pisos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                return HttpNotFound();

            return View(produto);
        }

        private ActionResult HttpNotFound()
        {
            return View(Index);
        }

        [HttpPost]
        public ActionResult Edit(Piso piso)
        {
            if (ModelState.IsValid)
            {
                var pisoExistente = pisos.FirstOrDefault(p => p.Id == piso.Id);

                if (pisoExistente == null)
                    return HttpNotFound();

                pisoExistente.Local = piso.Local;
                pisoExistente.Area1 = piso.Area1;
                pisoExistente.Area2 = piso.Area2;
                pisoExistente.Piso1 = piso.Piso1;
                pisoExistente.Piso2 = piso.Piso2;
                pisoExistente.CalculoArea = (pisoExistente.Area1 * pisoExistente.Area2);
                pisoExistente.CalculoPiso = pisoExistente.CalculoArea / (pisoExistente.Piso1 * pisoExistente.Piso2);

                return RedirectToAction("Index");
               
            }

            return View(piso);
        }

        public ActionResult Delete(int id)
        {
            var piso = pisos.FirstOrDefault(p => p.Id == id);

            if (piso == null)
                return HttpNotFound();

            pisos.Remove(piso);

            return RedirectToAction("Index");
        }
    }

}
