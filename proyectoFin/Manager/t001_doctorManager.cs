using MongoRepo.Manager;
using MongoRepo.Repository;
using proyectoFin.Interfaces.Manager;
using proyectoFin.Models;
using proyectoFin.Repository;

namespace proyectoFin.Manager
{
    public class t001_doctorManager : CommonManager<t001_doctor>, It001_doctorManager
    {
        public t001_doctorManager() : base(new t001_doctorRepository())
        {
        }
    }
}
