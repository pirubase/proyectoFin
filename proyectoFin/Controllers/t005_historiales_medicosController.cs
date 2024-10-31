using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t005_historiales_medicosController : Controller
    {

        private It005_historiales_medicosManager _t005_historiales_medicosManager = new t005_historiales_medicosManager();

        public IActionResult Index()
        {
            var historiales = _t005_historiales_medicosManager.GetAll();
            return View(historiales);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t005_historiales_medicos t005_historiales_medicos)
        {
            // t001_doctor.f001_id = Guid.NewGuid().ToString();
            bool isSaved = _t005_historiales_medicosManager.Add(t005_historiales_medicos);
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
            var t005_historiales_medicos = _t005_historiales_medicosManager.GetById(id);
            if (t005_historiales_medicos == null)
            {
                return NotFound();
            }
            return View(t005_historiales_medicos);
        }


        [HttpPost]
        public ActionResult Edit(t005_historiales_medicos t005_historiales_medicos)
        {
            bool isUpdated = _t005_historiales_medicosManager.Update(t005_historiales_medicos.f005_id, t005_historiales_medicos);
            string msg = "";
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t005_historiales_medicos);
        }

        public ActionResult Delete(ObjectId id)
        {
            var historia = _t005_historiales_medicosManager.GetById(id);
            if (historia == null)
            {
                return NotFound();
            }
            return View(historia);
        }

        [HttpPost]
        public ActionResult Delete(t005_historiales_medicos t005_historiales_medicos)
        {
            bool isDeleted = _t005_historiales_medicosManager.Delete(t005_historiales_medicos.f005_id);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id)
        {
            var historia = _t005_historiales_medicosManager.GetById(id);

            if (historia == null)
            {
                return NotFound();
            }
            return View(historia);
        }
    }
}
