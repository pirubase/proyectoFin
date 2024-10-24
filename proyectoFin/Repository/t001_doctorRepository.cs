using MongoRepo.Context;
using MongoRepo.Repository;
using proyectoFin.DataBase;
using proyectoFin.Interfaces.Repository;
using proyectoFin.Models;

namespace proyectoFin.Repository
{
    public class t001_doctorRepository : CommonRepository<t001_doctor>, It001_doctorRepository
    {
        public t001_doctorRepository():base(new ApplicationDbContext(DbConnection.ConnectionString,DbConnection.DBName))
        {
            
        }
    }
}
