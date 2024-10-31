using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t005_historiales_medicosRepository : CommonRepository<t005_historiales_medicos>, It005_historiales_medicosRepository
    {
        public t005_historiales_medicosRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString, DbConnection.DBName))
        {

        }
    }
}
