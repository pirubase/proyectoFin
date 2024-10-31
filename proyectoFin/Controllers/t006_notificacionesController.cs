using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t006_notificacionesController : Controller
    {

        private It006_notificacionesManager _t006_notificacionesManager = new t006_notificacionesManager();

        public IActionResult Index()
        {
            var notificaciones = _t006_notificacionesManager.GetAll();
            return View(notificaciones);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t006_notificaciones t006_notificaciones)
        {
            // t001_doctor.f001_id = Guid.NewGuid().ToString();
            bool isSaved = _t006_notificacionesManager.Add(t006_notificaciones);
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
            var t006_notificaciones = _t006_notificacionesManager.GetById(id);
            if (t006_notificaciones == null)
            {
                return NotFound();
            }
            return View(t006_notificaciones);
        }


        [HttpPost]
        public ActionResult Edit(t006_notificaciones t006_notificaciones)
        {
            bool isUpdated = _t006_notificacionesManager.Update(t006_notificaciones.f006_id, t006_notificaciones);
            string msg = "";
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t006_notificaciones);
        }

        public ActionResult Delete(ObjectId id)
        {
            var notificacion = _t006_notificacionesManager.GetById(id);
            if (notificacion == null)
            {
                return NotFound();
            }
            return View(notificacion);
        }

        [HttpPost]
        public ActionResult Delete(t006_notificaciones t006_notificaciones)
        {
            bool isDeleted = _t006_notificacionesManager.Delete(t006_notificaciones.f006_id);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id)
        {
            var notificacion = _t006_notificacionesManager.GetById(id);

            if (notificacion == null)
            {
                return NotFound();
            }
            return View(notificacion);
        }
    }
}
