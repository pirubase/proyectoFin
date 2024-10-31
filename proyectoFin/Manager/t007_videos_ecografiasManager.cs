using MongoRepo.Manager;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t007_videos_ecografiasManager : CommonManager<t007_videos_ecografias>, It007_videos_ecografiasManager
    {
        public t007_videos_ecografiasManager() : base(new t007_videos_ecografiasRepository())
        {
        }
    }
}
