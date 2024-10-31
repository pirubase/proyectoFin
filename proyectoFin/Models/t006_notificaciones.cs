using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyectoFin.Models
{
    public class t006_notificaciones
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId f006_id { get; set; }
        public DateTime f006_fechaEnvio { get; set; }
        public string f006_emailDestinatario { get; set; }
        public string f006_asuntoCorreo { get; set; }
        public string f006_mensajeCorreo { get; set; }
        public ObjectId f006_idCita { get; set; }  // FK to Citas
    }
}
