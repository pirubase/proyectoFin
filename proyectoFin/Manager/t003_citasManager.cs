using MongoRepo.Manager;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t003_citasManager : CommonManager<t003_citas>, It003_citasManager
    {
        public t003_citasManager() : base(new t003_citasRepository())
        {
        }
    }
}
