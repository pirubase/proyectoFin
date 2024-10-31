using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace proyectoFin.Models
{
    public class t001_doctor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId f001_id { get; set; }
        public string f001_especialidad { get; set; }
        public int f001_cedula { get; set; }
        public string f001_usuario { get; set; }
        public string f001_contrasena { get; set; }  // Hash
        public string f001_nombre { get; set; }
        public string f001_genero { get; set; }
        public int f001_telefono { get; set; }
        public string f001_direccion { get; set; }
        public string f001_departamento { get; set; }
        public string f001_ciudad { get; set; }
        public string f001_fechaNacimiento { get; set; }
    }
}
