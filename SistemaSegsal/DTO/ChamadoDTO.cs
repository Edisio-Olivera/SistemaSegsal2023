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
        private string _proposta;
        private DateTime _dataChamado;
        private string _cliente;
        private string _baseCliente;
        private string _localSetor;
        private string _equipamento;
        private string _contatoCliente;
        private string _situacao;
        private string _assunto;
        private string _urgencia;
        private string _informacaoCliente;
        private DateTime _dataVisita;
        private DateTime _horaVisita;
        private string _tecnico;
        private string _diagnostico;
        private string _solucao;
        private DateTime _dataFinal;
        private Int32 _valorTotal;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public DateTime DataChamado { get => _dataChamado; set => _dataChamado = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string BaseCliente { get => _baseCliente; set => _baseCliente = value; }
        public string ContatoCliente { get => _contatoCliente; set => _contatoCliente = value; }
        public string Assunto { get => _assunto; set => _assunto = value; }
        public string Urgencia { get => _urgencia; set => _urgencia = value; }
        public string InformacaoCliente { get => _informacaoCliente; set => _informacaoCliente = value; }
        public string Diagnostico { get => _diagnostico; set => _diagnostico = value; }
        public string Solucao { get => _solucao; set => _solucao = value; }
        public DateTime DataFinal { get => _dataFinal; set => _dataFinal = value; }
        public string Status { get => _status; set => _status = value; }
        public string LocalSetor { get => _localSetor; set => _localSetor = value; }
        public int ValorTotal { get => _valorTotal; set => _valorTotal = value; }
        public string Situacao { get => _situacao; set => _situacao = value; }
        public DateTime DataVisita { get => _dataVisita; set => _dataVisita = value; }
        public DateTime HoraVisita { get => _horaVisita; set => _horaVisita = value; }
        public string Tecnico { get => _tecnico; set => _tecnico = value; }
        public string Equipamento { get => _equipamento; set => _equipamento = value; }
        public string Proposta { get => _proposta; set => _proposta = value; }
    }
}
