using MongoRepo.Manager;
using MongoRepo.Repository;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t002_pacientesManager : CommonManager<t002_pacientes>, It002_pacientesManager
    {
        public t002_pacientesManager() : base(new t002_pacientesRepository())
        {
        }
    }
}
