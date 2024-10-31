using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t002_pacientesController : Controller
    {
        private It002_pacientesManager _t002_pacientesManager = new t002_pacientesManager();

        public IActionResult Index()
        {
            var pacientes = _t002_pacientesManager.GetAll();
            return View(pacientes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t002_pacientes t002_pacientes)
        {
            // t001_doctor.f001_id = Guid.NewGuid().ToString();
            bool isSaved = _t002_pacientesManager.Add(t002_pacientes);
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
            var t002_pacientes = _t002_pacientesManager.GetById(id);
            if (t002_pacientes == null)
            {
                return NotFound();
            }
            return View(t002_pacientes);
        }


        [HttpPost]
        public ActionResult Edit(t002_pacientes t002_pacientes)
        {
            bool isUpdated = _t002_pacientesManager.Update(t002_pacientes.f002_cedula, t002_pacientes);
            string msg = "";
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t002_pacientes);
        }

        public ActionResult Delete(ObjectId id)
        {
            var doctor = _t002_pacientesManager.GetById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        [HttpPost]
        public ActionResult Delete(t002_pacientes t002_pacientes)
        {
            bool isDeleted = _t002_pacientesManager.Delete(t002_pacientes.f002_cedula);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id)
        {
            var paciente = _t002_pacientesManager.GetById(id);

            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }
    }
}
