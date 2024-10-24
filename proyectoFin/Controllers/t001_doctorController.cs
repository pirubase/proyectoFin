using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t001_doctorController : Controller
    {

        private It001_doctorManager _t001_doctorManager = new t001_doctorManager();
        public IActionResult Index()
        {
            var doctores = _t001_doctorManager.GetAll();
            return View(doctores);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t001_doctor t001_doctor)
        {
          // t001_doctor.f001_id = Guid.NewGuid().ToString();
           bool isSaved = _t001_doctorManager.Add(t001_doctor);
            string msg = "";
            if (isSaved) {
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
            var t001_doctor = _t001_doctorManager.GetById(id);
            if (t001_doctor == null) 
            { 
                return NotFound();
            }
            return View(t001_doctor);
        }


        [HttpPost]
        public ActionResult Edit (t001_doctor t001_doctor) 
        {
           bool isUpdated = _t001_doctorManager.Update(t001_doctor.f001_id, t001_doctor);
            string msg = "";
            if (isUpdated) 
            { 
            return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t001_doctor);
        }

        public ActionResult Delete(ObjectId id)
        {
            var doctor = _t001_doctorManager.GetById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        [HttpPost]
        public ActionResult Delete(t001_doctor t001_doctor)
        {
           bool isDeleted = _t001_doctorManager.Delete(t001_doctor.f001_id);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id) 
        {
            var doctor = _t001_doctorManager.GetById(id);

            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }
    }
}
