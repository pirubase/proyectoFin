using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyectoFin.Models
{
    public class t005_historiales_medicos
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId f005_id { get; set; }
        public int f005_idPaciente { get; set; }  // FK to Pacientes
        public int[] f005_idDiagnosticos { get; set; }  // Array of FK to Diagnosticos
    }
}
