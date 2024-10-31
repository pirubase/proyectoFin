using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace proyectoFin.Models
{
    public class t002_pacientes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int f002_cedula { get; set; }
        public bool f002_esExtranjero { get; set; }
        public string f002_nacionalidad { get; set; }
        public string f002_usuario { get; set; }
        public string f002_contrasena { get; set; }  // Hash
        public string f002_nombre { get; set; }
        public string f002_genero { get; set; }
        public int f002_telefono { get; set; }
        public string f002_direccion { get; set; }
        public string f002_departamento { get; set; }
        public string f002_ciudad { get; set; }
        public string f002_fechaNacimiento { get; set; }
        public string f002_tipoSangre { get; set; }
        public int f002_mesesEmbarazo { get; set; }
        public DateTime f002_fechaUltimaEcografia { get; set; }
        public string f002_estadoCivil { get; set; }
        public string f002_alergias { get; set; }
    }
}
