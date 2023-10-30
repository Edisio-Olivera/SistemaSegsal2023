using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class NotaFiscalDTO
    {
        private Int32 _id;
        private string _codigo;
        private string _dataEmissao;
        private string _dataRecebimento;
        private string _tipoNotaFiscal;
        private string _codigoVerificacao;
        private string _cliente;
        private string _baseCliente;
        private Int32 _diasReceber;
        private string _competencia;
        private string _numeroPedido;
        private string _servico;
        private Int32 _valor;
        private string _status;
        private Int32 _ano;
        private Int32 _emissao;
        private Int32 _mes;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string DataEmissao { get => _dataEmissao; set => _dataEmissao = value; }
        public string DataRecebimento { get => _dataRecebimento; set => _dataRecebimento = value; }
        public string TipoNotaFiscal { get => _tipoNotaFiscal; set => _tipoNotaFiscal = value; }
        public string CodigoVerificacao { get => _codigoVerificacao; set => _codigoVerificacao = value; }
        public string Competencia { get => _competencia; set => _competencia = value; }
        public string NumeroPedido { get => _numeroPedido; set => _numeroPedido = value; }
        public string Servico { get => _servico; set => _servico = value; }
        public int Valor { get => _valor; set => _valor = value; }
        public string Status { get => _status; set => _status = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string BaseCliente { get => _baseCliente; set => _baseCliente = value; }
        public int DiasReceber { get => _diasReceber; set => _diasReceber = value; }
        public int Emissao { get => _emissao; set => _emissao = value; }
        public int Mes { get => _mes; set => _mes = value; }
    }
}
