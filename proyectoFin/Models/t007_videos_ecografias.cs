using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyectoFin.Models
{
    public class t007_videos_ecografias
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int f007_id { get; set; }
        public string f007_formato { get; set; }
        public string f007_tamano { get; set; }
        public string f007_resolucion { get; set; }
        public string f007_urlDescarga { get; set; }
        public int f007_idDiagnostico { get; set; }  // FK to Diagnosticos
    }
}
