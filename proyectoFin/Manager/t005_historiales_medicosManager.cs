using MongoRepo.Manager;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t005_historiales_medicosManager : CommonManager<t005_historiales_medicos>, It005_historiales_medicosManager
    {
        public t005_historiales_medicosManager() : base(new t005_historiales_medicosRepository())
        {
        }
    }
}
