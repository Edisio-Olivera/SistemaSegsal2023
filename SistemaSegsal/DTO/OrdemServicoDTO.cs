using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class OrdemServicoDTO
    {
        private Int32 _id;
        private string _codigo;
        private DateTime _dataRegistro;
        private string _cliente;
        private string _baseCliente;
        private string _titulo;
        private string _descricao;
        private string _obsevacao;
        private string _proposta;
        private Int32 _progresso;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public DateTime DataRegistro { get => _dataRegistro; set => _dataRegistro = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string BaseCliente { get => _baseCliente; set => _baseCliente = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Obsevacao { get => _obsevacao; set => _obsevacao = value; }
        public string Proposta { get => _proposta; set => _proposta = value; }
        public string Status { get => _status; set => _status = value; }
        public int Progresso { get => _progresso; set => _progresso = value; }
    }
}
