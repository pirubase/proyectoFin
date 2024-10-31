using MongoRepo.Manager;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t004_diagnosticosManager : CommonManager<t004_diagnosticos>, It004_diagnosticosManager
    {
        public t004_diagnosticosManager() : base(new t004_diagnosticosRepository())
        {
        }
    
    }
}
