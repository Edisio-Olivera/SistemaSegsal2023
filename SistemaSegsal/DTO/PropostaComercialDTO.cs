using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class PropostaComercialDTO
    {
		private Int32 _id;
		private string _codigo;
		private string _dataProposta;
		private string _titulo;
		private string _descricao;
		private string _observacao;
		private string _cliente;
		private string _baseCliente;
		private string _condicaoPgto;
		private string _formaPgto;
		private Int32 _valor;
		private string _notaFiscal;
		private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string DataProposta { get => _dataProposta; set => _dataProposta = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Observacao { get => _observacao; set => _observacao = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string BaseCliente { get => _baseCliente; set => _baseCliente = value; }
        public string CondicaoPgto { get => _condicaoPgto; set => _condicaoPgto = value; }
        public string FormaPgto { get => _formaPgto; set => _formaPgto = value; }
        public int Valor { get => _valor; set => _valor = value; }
        public string NotaFiscal { get => _notaFiscal; set => _notaFiscal = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
