using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyectoFin.Models
{
    public class t003_citas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId f003_id { get; set; }
        public DateTime f003_fechaCreacion { get; set; }
        public DateTime f003_fechaCita { get; set; }
        public string f003_estado { get; set; }
        public int f003_idPaciente { get; set; }  // FK to Pacientes
        public int f003_idEspecialista { get; set; }  // FK to Especialistas
    }
}
