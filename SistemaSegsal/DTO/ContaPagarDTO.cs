using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ContaPagarDTO
    {
        private Int32 _id;
        private DateTime _dataRegistro;
        private string _fornecedor;
        private string _tipoMovimentacao;
        private string _conta;
        private DateTime _dataTransacao;
        private string _descricao;
        private string _condPgto;
        private string _formaPgto;
        private Int32 _valorTransacao;
        private Int32 _qtdParcela;
        private string _parcela;
        private Int32 _valorParcela;
        private DateTime _dataVencimento;
        private DateTime _dataPgtoReceb;
        private Int32 _descJuros;
        private Int32 _valorTotal;
        private Int32 _dia;
        private Int32 _mes;
        private Int32 _ano;
        private Int32 _resultado;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public DateTime DataRegistro { get => _dataRegistro; set => _dataRegistro = value; }
        public string Fornecedor { get => _fornecedor; set => _fornecedor = value; }
        public string TipoMovimentacao { get => _tipoMovimentacao; set => _tipoMovimentacao = value; }
        public string Conta { get => _conta; set => _conta = value; }
        public DateTime DataTransacao { get => _dataTransacao; set => _dataTransacao = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string CondPgto { get => _condPgto; set => _condPgto = value; }
        public string FormaPgto { get => _formaPgto; set => _formaPgto = value; }
        public int ValorTransacao { get => _valorTransacao; set => _valorTransacao = value; }
        public int QtdParcela { get => _qtdParcela; set => _qtdParcela = value; }
        public string Parcela { get => _parcela; set => _parcela = value; }
        public int ValorParcela { get => _valorParcela; set => _valorParcela = value; }
        public DateTime DataVencimento { get => _dataVencimento; set => _dataVencimento = value; }
        public DateTime DataPgtoReceb { get => _dataPgtoReceb; set => _dataPgtoReceb = value; }
        public int DescJuros { get => _descJuros; set => _descJuros = value; }
        public int ValorTotal { get => _valorTotal; set => _valorTotal = value; }
        public string Status { get => _status; set => _status = value; }
        public int Dia { get => _dia; set => _dia = value; }
        public int Mes { get => _mes; set => _mes = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public int Resultado { get => _resultado; set => _resultado = value; }
    }
}
