using MongoRepo.Manager;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t006_notificacionesManager : CommonManager<t006_notificaciones>, It006_notificacionesManager
    {
        public t006_notificacionesManager() : base(new t006_notificacionesRepository())
        {
        }
    }
}
