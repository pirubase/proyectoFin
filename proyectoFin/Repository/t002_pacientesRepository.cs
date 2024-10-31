using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t002_pacientesRepository : CommonRepository<t002_pacientes>, It002_pacientesRepository
    {
        public t002_pacientesRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString, DbConnection.DBName))
        {

        }
    
    }
}
