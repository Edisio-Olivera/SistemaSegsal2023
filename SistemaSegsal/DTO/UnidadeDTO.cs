using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class UnidadeDTO
    {
        private Int32 _id;
        private string _unidade;
        private string _descricao;

        public int Id { get => _id; set => _id = value; }
        public string Unidade { get => _unidade; set => _unidade = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
