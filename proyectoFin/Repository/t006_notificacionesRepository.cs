using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t006_notificacionesRepository : CommonRepository<t006_notificaciones>, It006_notificacionesRepository
    {
        public t006_notificacionesRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString, DbConnection.DBName))
        {

        }
    }
}
