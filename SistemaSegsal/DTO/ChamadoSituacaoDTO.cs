using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoSituacaoDTO
    {
        private Int32 _id;
        private string _situacao;

        public int Id { get => _id; set => _id = value; }
        public string Situacao { get => _situacao; set => _situacao = value; }
    }
}
