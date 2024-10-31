using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t003_citasRepository : CommonRepository<t003_citas>, It003_citasRepository
    {
        public t003_citasRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString, DbConnection.DBName))
        {

        }
    }
}
