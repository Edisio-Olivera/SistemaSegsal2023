using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoDTO
    {
        private Int32 _id;
        private string _codigo;
        private string _dataChamado;
        private string _cliente;
        private string _baseCliente;
        private string _localSetor;
        private string _contatoCliente;
        private string _assunto;
        private string _urgencia;
        private string _informacaoCliente;
        private string _diagnostico;
        private string _solucao;
        private string _dataFinal;
        private Int32 _valorTotal;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string DataChamado { get => _dataChamado; set => _dataChamado = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string BaseCliente { get => _baseCliente; set => _baseCliente = value; }
        public string ContatoCliente { get => _contatoCliente; set => _contatoCliente = value; }
        public string Assunto { get => _assunto; set => _assunto = value; }
        public string Urgencia { get => _urgencia; set => _urgencia = value; }
        public string InformacaoCliente { get => _informacaoCliente; set => _informacaoCliente = value; }
        public string Diagnostico { get => _diagnostico; set => _diagnostico = value; }
        public string Solucao { get => _solucao; set => _solucao = value; }
        public string DataFinal { get => _dataFinal; set => _dataFinal = value; }
        public string Status { get => _status; set => _status = value; }
        public string LocalSetor { get => _localSetor; set => _localSetor = value; }
        public int ValorTotal { get => _valorTotal; set => _valorTotal = value; }
    }
}
