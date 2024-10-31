using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t007_videos_ecografiasRepository : CommonRepository<t007_videos_ecografias>, It007_videos_ecografiasRepository
    {
        public t007_videos_ecografiasRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString, DbConnection.DBName))
        {

        }
    }
}
