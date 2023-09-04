using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiPruebaTecMonolegal.Models
{
    public class Factura
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("codigoFactura")]
        public string CodigoFactura { get; set; }
        [BsonElement("cliente")]
        public string Cliente { get; set; }
        [BsonElement("ciudad")]
        public string Ciudad { get; set; }
        [BsonElement("nit")]
        public string Nit { get; set; }
        [BsonElement("subTotal")]
        public int SubTotal { get; set; }
        [BsonElement("fechaCrea")]
        public string FechaCrea { get; set; }
        [BsonElement("estado")]
        public string Estado { get; set; }
        [BsonElement("pagada")]
        public bool Pagada { get; set;  }
        [BsonElement("fechaPago")]
        public string FechaPago { get; set; }
    }
}
