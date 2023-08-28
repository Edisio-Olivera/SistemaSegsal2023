using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class PropostaComercialServicoDTO
    {
        private Int32 _id;
        private string _proposta;
        private string _tipoServico;
        private Int32 _qtd;
        private string _descricao;
        private Int32 _valorUnitario;
        private Int32 _valorTotal;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Proposta { get => _proposta; set => _proposta = value; }
        public string TipoServico { get => _tipoServico; set => _tipoServico = value; }
        public int Qtd { get => _qtd; set => _qtd = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int ValorTotal { get => _valorTotal; set => _valorTotal = value; }
        public string Status { get => _status; set => _status = value; }
        public int ValorUnitario { get => _valorUnitario; set => _valorUnitario = value; }
    }
}
