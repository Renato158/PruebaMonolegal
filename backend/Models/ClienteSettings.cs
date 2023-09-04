using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebaTecMonolegal.Models
{
    public class ClienteSettings : IClienteSettings
    {
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string Collection { get; set; }
    }

    public interface IClienteSettings
    {
        string Server { get; set; }
        string DataBase { get; set; }
        string Collection { get; set; }
    }
}
