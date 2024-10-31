using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t004_diagnosticosRepository : CommonRepository<t004_diagnosticos>, It004_diagnosticosRepository
    {
        public t004_diagnosticosRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString, DbConnection.DBName))
        {

        }
    }
}
