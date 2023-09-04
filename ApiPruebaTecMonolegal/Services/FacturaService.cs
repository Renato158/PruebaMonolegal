using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPruebaTecMonolegal.Models;
using MongoDB.Driver;

namespace ApiPruebaTecMonolegal.Services
{
    public class FacturaService
    {
        private IMongoCollection<Factura> _factura;

        public FacturaService(IClienteSettings settings)
        {
            var client = new MongoClient(settings.Server);
            var database = client.GetDatabase(settings.DataBase);
            _factura = database.GetCollection<Factura>(settings.Collection);

        }

        public List<Factura> Get()
        {
            return _factura.Find(d => true).ToList();
        }

        public void Update(string id, Factura factura)
        {
            _factura.ReplaceOne(factura => factura.Id == id, factura);
        }
    }
}
