using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyectoFin.Models
{
    public class t004_diagnosticos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int f004_id { get; set; }
        public string f004_informacion { get; set; }
        public DateTime f004_fechaCreacion { get; set; }
        public DateTime f004_fechaModificacion { get; set; }
        public int f004_idEspecialista { get; set; }  // FK to Especialistas
        public int f004_idPaciente { get; set; }  // FK to Pacientes
    }
}
