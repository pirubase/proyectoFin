using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Manager;
using proyectoFin.Models;

namespace proyectoFin.Controllers
{
    public class t007_videos_ecografiasController : Controller
    {

        private It007_videos_ecografiasManager _t007_videos_ecografiasManager = new t007_videos_ecografiasManager();

        public IActionResult Index()
        {
            var ecografias = _t007_videos_ecografiasManager.GetAll();
            return View(ecografias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(t007_videos_ecografias t007_videos_ecografias)
        {
            // t001_doctor.f001_id = Guid.NewGuid().ToString();
            bool isSaved = _t007_videos_ecografiasManager.Add(t007_videos_ecografias);
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
            var t006_notificaciones = _t007_videos_ecografiasManager.GetById(id);
            if (t006_notificaciones == null)
            {
                return NotFound();
            }
            return View(t006_notificaciones);
        }


        [HttpPost]
        public ActionResult Edit(t007_videos_ecografias t007_videos_ecografias)
        {
            bool isUpdated = _t007_videos_ecografiasManager.Update(t007_videos_ecografias.f007_id, t007_videos_ecografias);
            string msg = "";
            if (isUpdated)
            {
                return RedirectToAction("Index");
            }
            else
            {
                msg = "Error al actualizar doctor";
            }
            return View(t007_videos_ecografias);
        }

        public ActionResult Delete(ObjectId id)
        {
            var video = _t007_videos_ecografiasManager.GetById(id);
            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }

        [HttpPost]
        public ActionResult Delete(t007_videos_ecografias t007_videos_ecografias)
        {
            bool isDeleted = _t007_videos_ecografiasManager.Delete(t007_videos_ecografias.f007_id);
            if (isDeleted)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "El doctor no puedo ser eliminado";
            return View();
        }


        public ActionResult Details(ObjectId id)
        {
            var video = _t007_videos_ecografiasManager.GetById(id);

            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }
    }
}
