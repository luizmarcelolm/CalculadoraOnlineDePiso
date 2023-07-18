using System.Drawing;
using System.Globalization;
using System.Reflection;
using CalculadoraOnlineDePiso.Models;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using IronPdf;

namespace CalculadoraOnlineDePiso.Controllers
{
    public class PisoController : Controller
    {
        private static List<Piso> pisos = new List<Piso>(); // Lista para armazenar os produtos
        private int id;

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
                if (piso.Opcao == "NÃO")
                {
                    piso.CalculoArea = piso.Area1 * piso.Area2;
                    piso.CalculoArea = (float)Math.Round(piso.CalculoArea, 2);
                    piso.CalculoAreaPiso = (piso.Piso1 * piso.Piso2) / 10000;
                    piso.CalculoAreaPiso = (float)Math.Round(piso.CalculoAreaPiso, 2);
                    piso.CalculoPiso = piso.CalculoArea / piso.CalculoAreaPiso;
                    piso.CalculoPiso = (float)Math.Round(piso.CalculoPiso);

                    piso.Id = pisos.Count + 1;
                    pisos.Add(piso);
                    return RedirectToAction("Index");
                }

                else if (piso.Opcao == "SIM")
                {
                    piso.CalculoArea = piso.Area1 * piso.Area2;
                    piso.CalculoArea = (float)Math.Round(piso.CalculoArea, 2);
                    piso.CalculoAreaPiso = (piso.Piso1 * piso.Piso2) / 10000;
                    piso.CalculoAreaPiso = (float)Math.Round(piso.CalculoAreaPiso, 2);
                    piso.CalculoPiso = piso.CalculoArea / piso.CalculoAreaPiso;
                    piso.CalculoPiso = piso.CalculoPiso + (piso.CalculoPiso * 10 / 100);
                    piso.CalculoPiso = (float)Math.Round(piso.CalculoPiso);


                    piso.Id = pisos.Count + 1;
                    pisos.Add(piso);
                    return RedirectToAction("Index");
                }


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

        [HttpPost]
        public ActionResult Edit(Piso piso)
        {
            if (ModelState.IsValid)
            {
                var pisoExistente = pisos.FirstOrDefault(p => p.Id == piso.Id);

                if (pisoExistente == null)
                    return HttpNotFound();

                if (piso.Opcao == "NÃO")
                {
                    pisoExistente.Opcao = piso.Opcao;
                    pisoExistente.Opcao = "NÃO";
                    pisoExistente.Local = piso.Local;
                    pisoExistente.Area1 = piso.Area1;
                    pisoExistente.Area2 = piso.Area2;
                    pisoExistente.Piso1 = piso.Piso1;
                    pisoExistente.Piso2 = piso.Piso2;
                    pisoExistente.CalculoArea = (pisoExistente.Area1 * pisoExistente.Area2);
                    pisoExistente.CalculoArea = (float)Math.Round(pisoExistente.CalculoArea, 2);
                    pisoExistente.CalculoAreaPiso = (pisoExistente.Piso1 * pisoExistente.Piso2) / 10000;
                    pisoExistente.CalculoAreaPiso = (float)Math.Round(pisoExistente.CalculoAreaPiso, 2);
                    pisoExistente.CalculoPiso = pisoExistente.CalculoArea / pisoExistente.CalculoAreaPiso;
                    pisoExistente.CalculoPiso = pisoExistente.CalculoPiso;
                    pisoExistente.CalculoPiso = (float)Math.Round(pisoExistente.CalculoPiso, 0);

                    return RedirectToAction("Index");

                } else if (piso.Opcao == "SIM")
                {
                    pisoExistente.Opcao = piso.Opcao;
                    pisoExistente.Opcao = "SIM";
                    pisoExistente.Local = piso.Local;
                    pisoExistente.Area1 = piso.Area1;
                    pisoExistente.Area2 = piso.Area2;
                    pisoExistente.Piso1 = piso.Piso1;
                    pisoExistente.Piso2 = piso.Piso2;
                    pisoExistente.CalculoArea = (pisoExistente.Area1 * pisoExistente.Area2);
                    pisoExistente.CalculoArea = (float)Math.Round(pisoExistente.CalculoArea, 2);
                    pisoExistente.CalculoAreaPiso = (pisoExistente.Piso1 * pisoExistente.Piso2) / 10000;
                    pisoExistente.CalculoAreaPiso = (float)Math.Round(pisoExistente.CalculoAreaPiso, 2);
                    pisoExistente.CalculoPiso = pisoExistente.CalculoArea / pisoExistente.CalculoAreaPiso;
                    pisoExistente.CalculoPiso = pisoExistente.CalculoPiso + (pisoExistente.CalculoPiso * 10 / 100);
                    pisoExistente.CalculoPiso = pisoExistente.CalculoPiso;
                    pisoExistente.CalculoPiso = (float)Math.Round(pisoExistente.CalculoPiso, 0);
                    return RedirectToAction("Index");
                }

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

        public ActionResult Look(int id)
        {
            var produto = pisos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
                return HttpNotFound();

            return View(produto);
        }

        [HttpPost]
        public ActionResult Look(Piso piso)
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
                pisoExistente.CalculoPiso = (pisoExistente.CalculoArea / ((pisoExistente.Piso1 / 100) * (pisoExistente.Piso2 / 100)));
                pisoExistente.CalculoPiso = (float)Math.Round(pisoExistente.CalculoPiso);

                return RedirectToAction("Index");
            }

            return View(piso);
        }

        public ActionResult Information()
        {
            return View();
        }

        private ActionResult HttpNotFound()
        {
            return View(Index);
        }

        public FileResult PaginaPDF(Piso piso)
        {
            
            var produto = pisos.FirstOrDefault(p => p.Id == id);
 
            var renderer = new ChromePdfRenderer();           
            var pdf = renderer.RenderUrlAsPdf("https://localhost:7091/Piso/Look/" + piso.Id);      
            pdf.SaveAs("output.pdf");
            return File(pdf.BinaryData, "application/pdf;");
        }      
    }

}
