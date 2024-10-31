using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t003_citasController : Controller
    {

        private It003_citasManager _t003_citasManager = new t003_citasManager();

        public IActionResult Index()
        {
            var citas = _t003_citasManager.GetAll();
            return View(citas);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t003_citas t003_citas)
        {
            // t001_doctor.f001_id = Guid.NewGuid().ToString();
            bool isSaved = _t003_citasManager.Add(t003_citas);
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
            var t003_citas = _t003_citasManager.GetById(id);
            if (t003_citas == null)
            {
                return NotFound();
            }
            return View(t003_citas);
        }


        [HttpPost]
        public ActionResult Edit(t003_citas t003_citas)
        {
            bool isUpdated = _t003_citasManager.Update(t003_citas.f003_id, t003_citas);
            string msg = "";
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t003_citas);
        }

        public ActionResult Delete(ObjectId id)
        {
            var cita = _t003_citasManager.GetById(id);
            if (cita == null)
            {
                return NotFound();
            }
            return View(cita);
        }

        [HttpPost]
        public ActionResult Delete(t003_citas t003_citas)
        {
            bool isDeleted = _t003_citasManager.Delete(t003_citas.f003_id);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id)
        {
            var cita = _t003_citasManager.GetById(id);

            if (cita == null)
            {
                return NotFound();
            }
            return View(cita);
        }
    }
}
