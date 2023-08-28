using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ClienteContatoDTO
    {
        private Int32 _id;
        private string _cliente;
        private string _nome;
        private string _telefone;
        private string _email;
        private string _departamento;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
