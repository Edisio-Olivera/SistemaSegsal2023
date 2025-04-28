using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class FornecedorContatoDTO
    {
        private Int32 _id;
        private string _codLoja;
        private string _nome;
        private string _funcao;
        private string _telefone;
        private string _celular;
        private string _email;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string CodLoja { get => _codLoja; set => _codLoja = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Funcao { get => _funcao; set => _funcao = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
