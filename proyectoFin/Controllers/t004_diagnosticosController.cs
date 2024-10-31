using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t004_diagnosticosController : Controller
    {

        private It004_diagnosticosManager _t004_diagnosticosManager = new t004_diagnosticosManager();

        public IActionResult Index()
        {
            var diagnosticos = _t004_diagnosticosManager.GetAll();
            return View(diagnosticos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t004_diagnosticos t004_diagnosticos)
        {
            // t001_doctor.f001_id = Guid.NewGuid().ToString();
            bool isSaved = _t004_diagnosticosManager.Add(t004_diagnosticos);
            string msg = "";
            if (isSaved)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al guardar el doctor";
            }

            ViewBag.msg = msg;
            return View();
        }

        public ActionResult Edit(ObjectId id)
        {
            var t004_diagnosticos = _t004_diagnosticosManager.GetById(id);
            if (t004_diagnosticos == null)
            {
                return NotFound();
            }
            return View(t004_diagnosticos);
        }


        [HttpPost]
        public ActionResult Edit(t004_diagnosticos t004_diagnosticos)
        {
            bool isUpdated = _t004_diagnosticosManager.Update(t004_diagnosticos.f004_id, t004_diagnosticos);
            string msg = "";
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t004_diagnosticos);
        }

        public ActionResult Delete(ObjectId id)
        {
            var diagnostico = _t004_diagnosticosManager.GetById(id);
            if (diagnostico == null)
            {
                return NotFound();
            }
            return View(diagnostico);
        }

        [HttpPost]
        public ActionResult Delete(t004_diagnosticos t004_diagnosticos)
        {
            bool isDeleted = _t004_diagnosticosManager.Delete(t004_diagnosticos.f004_id);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id)
        {
            var diagnostico = _t004_diagnosticosManager.GetById(id);

            if (diagnostico == null)
            {
                return NotFound();
            }
            return View(diagnostico);
        }
    }
}
