using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ClienteDTO
    {
		private Int32 _id;
		private string _codigo;
		private string _tipoCliente;
		private string _dataRegistro;
		private string _razaoSocial;
		private string _nomeFantasia;
		private string _logomarca;
		private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string TipoCliente { get => _tipoCliente; set => _tipoCliente = value; }
        public string DataRegistro { get => _dataRegistro; set => _dataRegistro = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public string NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string Logomarca { get => _logomarca; set => _logomarca = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
