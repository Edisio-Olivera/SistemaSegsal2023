using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ClienteTipoDTO
    {
        private Int32 _id;
        private string _tipoCliente;

        public int Id { get => _id; set => _id = value; }
        public string TipoCliente { get => _tipoCliente; set => _tipoCliente = value; }
    }
}
