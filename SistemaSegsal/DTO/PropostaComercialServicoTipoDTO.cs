using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class PropostaComercialServicoTipoDTO
    {
        private Int32 _id;
        private string _tipoServico;
        private string _descricao;

        public int Id { get => _id; set => _id = value; }
        public string TipoServico { get => _tipoServico; set => _tipoServico = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
