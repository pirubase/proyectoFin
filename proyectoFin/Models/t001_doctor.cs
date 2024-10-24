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

        [Display(Name = "Nombre")]
        public string f001_nombre { get; set; }

        [Display(Name = "Correo electronico")]
        public string f001_email { get; set; }

        [Display(Name = "Contraseña")]
        public  string f001_password { get; set; }
    }
}
